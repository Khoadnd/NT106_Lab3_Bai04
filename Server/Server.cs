using System.Net;
using System.Net.Sockets;
using System.Text;


namespace Bai4
{
    public partial class Server : Form
    {
        private TcpListener serverListener;
        private Dictionary<Socket, string> clients;

        public Server()
        {
            clients = new Dictionary<Socket, string>();
            InitializeComponent();
        }

        private void RelayMessage(string message)
        {
            clients.ToList().ForEach(client => client.Key.Send(Encoding.ASCII.GetBytes(message)));
        }

        private void StartProcessing(Socket clientSocket)
        {
            txtMessage.AppendText(clientSocket.RemoteEndPoint + " connected!\n");

            while (clientSocket.Connected)
            {
                var text = "";
                do
                {
                    var data = new byte[1];
                    clientSocket.Receive(data);
                    text += Encoding.ASCII.GetString(data);
                }
                while (text[^1] != '\n');

                if (text.Contains("Username: "))
                {
                    clients[clientSocket] = text.Split(": ")[1].Trim();
                    continue;
                }

                txtMessage.AppendText(clientSocket.RemoteEndPoint + ": " + clients[clientSocket] + ": " + text);
                RelayMessage(clientSocket.RemoteEndPoint + ": " + clients[clientSocket] + ": " + text);
            }

            txtMessage.AppendText(clientSocket.RemoteEndPoint + ": " + clients[clientSocket] + " disconnected!\n");
            clientSocket.Close();
            clients.Remove(clientSocket);
        }

        private void Run()
        {
            serverListener = new TcpListener(IPAddress.Any, 42069);
            serverListener.Start();
            txtMessage.AppendText("Server is listening on 127.0.0.1:42069\n");

            while (true)
            {
                clients.Add(serverListener.AcceptSocket(), "");
                var clientThread = new Thread(() => StartProcessing(clients.Last().Key));
                clientThread.Start();
            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            btnListen.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;
            var server = new Thread(new ThreadStart(Run));
            server.Start();
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverListener.Stop();
        }
    }
}