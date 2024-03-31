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
        public string SBServer {  get; set; }
        public string SBPort { get; set; }
        public LayoutMode Mode { get; set; }
        public bool ISConnected { get; set; }

        public StreamerBotSettings()
        {
            InitializeComponent();
        }

        private void StreamerBotSettings_Load(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            SBServer = txtServer.Text;
            SBPort = txtPort.Text;
            await ConnectionTest(SBServer, SBPort);
        }

        private async Task<bool> ConnectionTest(string ws, string port)
        {
            Uri uri = new Uri("ws://" + ws + ":" + port + "/");
            ClientWebSocket webSocket = new ClientWebSocket();

            try
            {
                await webSocket.ConnectAsync(uri, CancellationToken.None);
                MessageBox.Show("WebSocket connected to :\n" + "ws://" + ws + ":" + port + "/");

                // Request actions
                string requestJson = "{\"request\": \"GetActions\", \"id\": \"my-get-actions-id\"}";
                byte[] requestBuffer = Encoding.UTF8.GetBytes(requestJson);
                await webSocket.SendAsync(new ArraySegment<byte>(requestBuffer), WebSocketMessageType.Text, true, CancellationToken.None);

                // Receive the response
                List<byte> responseBytes = new List<byte>();
                WebSocketReceiveResult result;
                do
                {
                    byte[] buffer = new byte[8192];
                    result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    responseBytes.AddRange(buffer.Take(result.Count));
                }
                while (!result.EndOfMessage);

                // Convert the received bytes to a string
                string responseJson = Encoding.UTF8.GetString(responseBytes.ToArray());

                // Parse the JSON response
                JObject responseObject = JObject.Parse(responseJson);

                // Extract actions from the response
                JArray actionsArray = (JArray)responseObject["actions"];
                List<string> actionsList = new List<string>();
                foreach (JToken actionToken in actionsArray)
                {
                    string actionName = (string)actionToken["name"];
                    actionsList.Add(actionName);
                }

                // Populate the combo box with actions
                cbActions.Items.Clear();
                cbActions.Items.AddRange(actionsList.ToArray());

                // Close the connection
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
    }
}
