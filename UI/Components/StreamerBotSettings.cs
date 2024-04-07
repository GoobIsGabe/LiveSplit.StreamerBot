using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms.VisualStyles;
using System.Text;
using LiveSplit.Options;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace LiveSplit.UI.Components
{
    public partial class StreamerBotSettings : UserControl
    {
        public LayoutMode Mode { get; set; } //Need this in or else LiveSplit gets mad
        public string SBServer {  get; set; } //Depicts the Streamer.Bot websocket URL
        public string SBPort { get; set; } //Depicts the Streamer.Bot websocket port
        public bool ISConnected { get; set; } //Bool to determine if connected or not (I didn't make use of this yet)

        //You need this to literally start the project
        public StreamerBotSettings()
        {
            InitializeComponent();
        }
        //This is useful for something...what it is for I'm still learning
        private void StreamerBotSettings_Load(object sender, EventArgs e)
        {
            
        }
        //Action for the connect button, FeelsWowMan
        private async void btnConnect_Click(object sender, EventArgs e)
        {
            SBServer = txtServer.Text; 
            SBPort = txtPort.Text;
            await ConnectionTest(SBServer, SBPort);
        }
        //Ensures that there is a proper connection when testing.
        private async Task<bool> ConnectionTest(string ws, string port)
        {
            //Assigns the websocket link
            Uri uri = new Uri("ws://" + ws + ":" + port + "/");
            ClientWebSocket webSocket = new ClientWebSocket();

            try
            {
                await webSocket.ConnectAsync(uri, CancellationToken.None);
                MessageBox.Show("WebSocket connected to :\n" + "ws://" + ws + ":" + port + "/");

                //Gets the list of all actions
                string requestJson = "{\"request\": \"GetActions\", \"id\": \"my-get-actions-id\"}";
                //We don't know how much of a buffer to add, so we get exactly what we need
                byte[] requestBuffer = Encoding.UTF8.GetBytes(requestJson);
                await webSocket.SendAsync(new ArraySegment<byte>(requestBuffer), WebSocketMessageType.Text, true, CancellationToken.None);

                //Get the goods from the request
                List<byte> responseBytes = new List<byte>();
                WebSocketReceiveResult result;
                //Make the buffer larger until we make it to the end as necessary!
                do
                {
                    byte[] buffer = new byte[8192];
                    result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    responseBytes.AddRange(buffer.Take(result.Count));
                }
                while (!result.EndOfMessage);

                //Convert the received bytes to a string
                string responseJson = Encoding.UTF8.GetString(responseBytes.ToArray());

                //Parse the JSON response
                JObject responseObject = JObject.Parse(responseJson);

                //Extract actions from the response
                JArray actionsArray = (JArray)responseObject["actions"];
                List<string> actionsList = new List<string>();
                foreach (JToken actionToken in actionsArray)
                {
                    string actionName = (string)actionToken["name"]; //We populate the actionsList for each "name" parameter
                    actionsList.Add(actionName);
                }

                //Populate the combo box with actions
                cbActions.Items.Clear();
                cbActions.Items.AddRange(actionsList.ToArray());

                //Close the connection
                await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Connection closed by client", CancellationToken.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                if (webSocket.State == WebSocketState.Open)
                    await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Connection closed by client", CancellationToken.None);
                webSocket.Dispose();
            }

            return true;
        }
        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.0") ^
                SettingsHelper.CreateSetting(document, parent, "SBServer", SBServer) ^
                SettingsHelper.CreateSetting(document, parent, "SBPort", SBPort);
        }
        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }
        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
            SBServer = SettingsHelper.ParseString(element["SBServer"]);
            SBPort = SettingsHelper.ParseString(element["SBPort"]);
            txtServer.Text = SBServer;
            txtPort.Text = SBPort;
        }

        private int sectionCount = 1;
        private int verticalPosition = 19;

        private void btnAddCurrentSplit_Click(object sender, EventArgs e)
        {
            CreateNewSection(grpCurrentSplit);
        }

        private void CreateNewSection(GroupBox targetGroup)
        {
            //Create a new table layout panel for the section
            TableLayoutPanel tblNewSection = new TableLayoutPanel();
            tblNewSection.ColumnCount = 2;
            tblNewSection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblNewSection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblNewSection.RowCount = 4;
            tblNewSection.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblNewSection.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblNewSection.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblNewSection.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));

            //Creates the contents
            TextBox txtCurrentSplit = new TextBox();
            Label lblCurrentSplit = new Label();
            TextBox txtCurrentSplitID = new TextBox();
            Label lblCurrentSplitID = new Label();
            TextBox txtCurrentSplitAction = new TextBox();
            Label lblActionID = new Label();
            Button btnCurrentSplitRemove = new Button();
            Button btnCurrentSplitSave = new Button();

            //Properties for the controls
            txtCurrentSplit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCurrentSplitID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCurrentSplitAction.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            lblCurrentSplit.Text = "Current Split:";
            lblCurrentSplitID.Text = "ID:";
            lblActionID.Text = "Action ID:";
            btnCurrentSplitRemove.Text = "Remove";
            btnCurrentSplitSave.Text = "Save";

            //Add click event handler for the remove button
            btnCurrentSplitRemove.Click += RemoveButton_Click;

            //Add the remove button's associated section to its Tag property
            btnCurrentSplitRemove.Tag = tblNewSection;

            //Add controls to the table layout panel
            tblNewSection.Controls.Add(lblCurrentSplit, 0, 0);
            tblNewSection.Controls.Add(txtCurrentSplit, 1, 0);
            tblNewSection.Controls.Add(lblCurrentSplitID, 0, 2);
            tblNewSection.Controls.Add(txtCurrentSplitID, 1, 2);
            tblNewSection.Controls.Add(lblActionID, 0, 1);
            tblNewSection.Controls.Add(txtCurrentSplitAction, 1, 1);
            tblNewSection.Controls.Add(btnCurrentSplitRemove, 0, 3);
            tblNewSection.Controls.Add(btnCurrentSplitSave, 1, 3);

            //Add the new section to the group box
            tblNewSection.Location = new Point(10, verticalPosition);
            targetGroup.Controls.Add(tblNewSection);
            // Increment the section count
            sectionCount++;

            // Adjust the vertical position for the next section
            verticalPosition += tblNewSection.Height + 5;

            // Adjust the positions of the groups below the target group


            // Adjust the size of the target group to accommodate the new section
            targetGroup.Size = new Size(targetGroup.Size.Width, targetGroup.Size.Height + tblNewSection.Height + 5);
        }
        private void AdjustPositions(GroupBox targetGroup, TableLayoutPanel addedSection)
        {
            int addedIndex = targetGroup.Controls.IndexOf(addedSection);
            int yPos = addedSection.Bottom + 5;

            for (int i = addedIndex + 1; i < targetGroup.Controls.Count; i++)
            {
                Control control = targetGroup.Controls[i];
                control.Location = new Point(control.Location.X, yPos);
                yPos += control.Height + 5;
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //Gets the associated section from the Tag property of the remove button
            Button removeButton = (Button)sender;
            TableLayoutPanel sectionToRemove = (TableLayoutPanel)removeButton.Tag;


            int removeIndex = grpCurrentSplit.Controls.IndexOf(sectionToRemove);

            grpCurrentSplit.Controls.Remove(sectionToRemove);

            //Re-position the remaining sections below the removed section
            for (int i = removeIndex; i < grpCurrentSplit.Controls.Count; i++)
            {
                Control section = grpCurrentSplit.Controls[i];
                section.Location = new Point(section.Location.X, section.Location.Y - sectionToRemove.Height - 5);
            }

            sectionCount--;

            //Adjust the vertical position for the next section
            verticalPosition -= sectionToRemove.Height + 5;

            //Adjust the size of the group box to accommodate the removed section
            grpCurrentSplit.Size = new Size(grpCurrentSplit.Size.Width, grpCurrentSplit.Size.Height - sectionToRemove.Height - 5);
        }

        private void btnAddStart_Click(object sender, EventArgs e)
        {
            //CreateNewSection(grpStartRun);
        }
    }
}
