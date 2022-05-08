using System.Net.Sockets;
using System.Text;

namespace Bai4
{
    public partial class Client : Form
    {
        private TcpClient client;
        public Client()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void ReceiveMessage()
        {
            var stream = new StreamReader(client.GetStream());
            while (true)
            {
                var msg = stream.ReadLine();
                txtMessageReceived.AppendText(msg + '\n');
            }
        }

        private void SendMessage(string message)
        {
            if (client == null) return;
            var stream = client.GetStream();
            var data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage(txtMessage.Text.Trim() + "\n");
            txtMessage.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("127.0.0.1", 42069);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            btnConnect.Enabled = false;
            txtMessageReceived.AppendText("Connected!\n");

            txtName.Enabled = false;
            SendMessage("Username: " + txtName.Text.Trim() + "\n");

            var rcv = new Thread(new ThreadStart(ReceiveMessage));
            rcv.Start();
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
        }
    }
}
