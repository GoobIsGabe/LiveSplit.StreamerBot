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

                // Listen for messages
               // await Receive(webSocket);

                // Send messages (if needed)
                // await Send(webSocket, "Hello, server!");

                // Close the connection
               // await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Connection closed by client", CancellationToken.None);
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
