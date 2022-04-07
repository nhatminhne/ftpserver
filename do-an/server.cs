using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an
{
    public partial class Server : Form
    {
        List<Socket> ClientList = new List<Socket>();

        Socket listenerSocket = new Socket(
           AddressFamily.InterNetwork,
           SocketType.Stream,
           ProtocolType.Tcp
           );

        Socket listenerSocke = new Socket(
           AddressFamily.InterNetwork,
           SocketType.Stream,
           ProtocolType.Tcp
           );

        int i = 0;
        //string k;

        public Server()
        {
            InitializeComponent();
        }

        private void listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.IsBackground = true;
            serverThread.Start();

            Thread serverthrea = new Thread(new ThreadStart(StartUnsafeThrea));
            serverthrea.IsBackground = true;
            serverthrea.Start();
        }

        private async void StartUnsafeThread()
        {
            Socket clientSocket;
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("192.168.1.5"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);
            try
            {
                while (true)
                {
                    clientSocket = await listenerSocket.AcceptAsync();
                    ClientList.Add(clientSocket);
                    Thread TCPClient = new Thread(TCPThread);
                    TCPClient.Start(clientSocket);
                    i++;
                    num.Text = "Client: " + i.ToString();
                }
            }catch (Exception) { }
        }

        private async void StartUnsafeThrea()
        {
            Socket clientSocket;
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("25.11.80.205"), 8080);
            listenerSocke.Bind(ipepServer);
            listenerSocke.Listen(-1);
            try
            {
                while (true)
                {
                    clientSocket = await listenerSocke.AcceptAsync();
                    ClientList.Add(clientSocket);
                    Thread TCPClient = new Thread(TCPThread);
                    TCPClient.Start(clientSocket);
                    i++;
                    num.Text = "Client: " + i.ToString();
                }
            }
            catch (Exception) { }
        }

        private void TCPThread(object clientSocket)
        {
            Socket clientSocket1 = (Socket)clientSocket;

            while ((clientSocket1.Poll(-1, SelectMode.SelectRead)) && (clientSocket1.Available != 0))
            {
                string text = "";
                byte[] recv = new byte[1000000];
                int byterecv;

                while((byterecv = clientSocket1.Receive(recv)) != 0)
                {
                    //Thread.Sleep(2000);
                    //MessageBox.Show("");
                    text = Encoding.UTF8.GetString(recv, 0, byterecv);

                    if (text.Contains("ftp") == true)
                    {
                        text = "Server:\nConnected to 25.11.80.205.\n220 Nhom 4 FTP Service\n200 OPTS UTF8 command successful - UTF8 encoding now ON.\n230 User logged in.";
                        send(text, clientSocket1);
                    }
                    else if (text.Contains("cwd") == true)
                    {
                        text = "\n\nServer:\n250 CWD command successful.\n200 PORT command successful.\n125 Data connection already open; Transfer starting.\n226 Transfer complete.";
                        send(text, clientSocket1);
                    }
                    else if (text.Contains("download") == true)
                    {
                        byte[] downloadFile = { 1 };
                        string[] splitPath = text.Split('/');
                        string path = "//25.11.80.205//server//" + splitPath[1];
                        //string path = "//DESKTOP-3VE6VUN/server" + splitPath[1];

                        path = path.TrimEnd('\r', '\n', '\0');
                        byte[] dataToSend = combine(downloadFile, File.ReadAllBytes(path));
                        NetworkStream ns = new NetworkStream(clientSocket1);
                        ns.Write(dataToSend, 0, dataToSend.Length);

                        text = "\n\nServer:\n200 PORT command successful.\n125 Data connection already open; Transfer starting.\n226 Transfer complete.";
                        send(text, clientSocket1);

                    }
                    else if (text.Contains("delete") == true)
                    {
                        text = "\n\nServer:\n250 DELE command successful";
                        send(text, clientSocket1);
                    }
                    else if (text.Contains("quit") == true)
                    {
                        text = "\n\nServer:\n221 Goodbye.\n\n";
                        send(text, clientSocket1);
                        i--;
                        num.Text = "Client: " + i.ToString();
                        ClientList.Remove(clientSocket1);
                    }
                    else
                    {
                        string para = text.Substring(text.LastIndexOf("\\") + 1);
                        //MessageBox.Show(para.Length.ToString() + "  " + para);
                        byterecv -= 1;
                        byterecv -= para.Length;
                        FileStream sw = new FileStream("//DESKTOP-3VE6VUN/server/" + para, FileMode.Create);
                        sw.Write(recv, 0, byterecv);
                        sw.Close();

                        text = "\n\nServer:\n200 PORT command successful.\n125 Data connection already open; Transfer starting.\n226 Transfer complete.";
                        send(text, clientSocket1);
                    }
                    //Thread.Sleep(2000);
                    //MessageBox.Show("ô");
                }
            }
            //i--;
            //num.Text = "Client: " + i.ToString();
        }

        private void send(string message, Socket socket)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            NetworkStream ns = new NetworkStream(socket);
            ns.Write(buffer, 0, buffer.Length);
        }

        private byte[] combine(byte[] first, byte[] second)
        {
            return first.Concat(second).ToArray();
        }

        private void Split<T>(T[] array, int index, out T[] first, out T[] second)
        {
            first = array.Take(index).ToArray();
            second = array.Skip(index).ToArray();
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            listenerSocket.Close();
        }
    }
}
