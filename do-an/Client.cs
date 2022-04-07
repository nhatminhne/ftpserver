using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an
{
    public partial class Client : Form
    {
        NetworkStream ns;
        TcpClient tcpClient;
        String sendRequestFile = "";
        int check = 0;
        int connec = 0;

        public Client()
        {
            InitializeComponent();
        }

        private async void connect_Click(object sender, EventArgs e)
        {
            if (connec == 0)
            {
                StreamReader sr = new StreamReader("//DESKTOP-3VE6VUN/server/login.txt");
                string content = sr.ReadToEnd();
                sr.Close();
                string m = user.Text, n = pass.Text;
                string ip = ip_server.Text;
                if (ip == "25.11.80.205" || ip == "192.168.1.5")
                {
                    if ((content.Contains(m) == true) && (content.Contains(n) == true))
                    {
                        tcpClient = new TcpClient();
                        IPAddress ipAddress = IPAddress.Parse("192.168.1.5");
                        await tcpClient.ConnectAsync(ipAddress, 8080);
                        ns = tcpClient.GetStream();

                        Byte[] data = Encoding.UTF8.GetBytes("ftp");
                        ns.Write(data, 0, data.Length);

                        CheckForIllegalCrossThreadCalls = false;
                        Thread serverThread = new Thread(StartUnsafeThread);
                        serverThread.Start(tcpClient);

                        Thread file = new Thread(file_explo);
                        file.Start();
                        check = 1;
                        connec++;
                    }
                    else
                        MessageBox.Show("User/password không đúng");
                }
                else MessageBox.Show("IP không đúng");
            }
        }

        private void file_explo()
        {
            webBrowser1.Url = new Uri("file://DESKTOP-3VE6VUN/server/");
        }

        private void StartUnsafeThread(object obj)
        {
            TcpClient tcpClient = (TcpClient)obj;
            NetworkStream ns = tcpClient.GetStream();

            byte[] BytesReceived = new byte[1000000];
            try
            {
                while (tcpClient.Connected)
                {
                    string text = "";
                    int bytere;
                    bytere = ns.Read(BytesReceived, 0, BytesReceived.Length);

                    if (BytesReceived[0] == 1)
                    {
                        byte[] arr1;
                        byte[] files;
                        Split(BytesReceived, 1, out arr1, out files);
                        string[] splitArray = sendRequestFile.Split('/');
                        bytere -= 1;
                        FileStream sw = new FileStream("D:/" + splitArray[1], FileMode.Create);
                        sw.Write(files, 0, bytere);
                        sw.Close();
                        MessageBox.Show("File " + splitArray[1] + " được lưu ở D:/");
                    }
                    else
                    {
                        text = Encoding.UTF8.GetString(BytesReceived, 0, bytere);
                        richTextBox1.Text += text;
                        richTextBox1.Focus();
                        richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    }
                }
                ns.Close();
                tcpClient.Close();
            }
            catch (Exception) { }

        }

        private void Split<T>(T[] array, int index, out T[] first, out T[] second)
        {
            first = array.Take(index).ToArray();
            second = array.Skip(index).ToArray();
        }

        private void send_Click_1(object sender, EventArgs e)
        {
            if (check != 0)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                try
                {
                    ofd.InitialDirectory = "file:C:/Users/minhN/Desktop";
                    ofd.ShowDialog();
                    string k = ofd.FileName;
                    k = k.Substring(k.LastIndexOf('\\') + 1);

                    byte[] para = Encoding.ASCII.GetBytes("\\" + k);
                    //MessageBox.Show(para.Length.ToString()+"   " + k);
                    byte[] data = File.ReadAllBytes(ofd.FileName);
                    byte[] dataToSend = combine(data, para);
                    ns.Write(dataToSend, 0, dataToSend.Length);

                    webBrowser1.Url = new Uri("file://DESKTOP-3VE6VUN/server/");
                    MessageBox.Show("Gửi " + k + " thành công");
                }
                catch (Exception) { }
            }
            else MessageBox.Show("Bạn chưa đăng nhập");
        }

        private byte[] combine(byte[] first, byte[] second)
        {
            return first.Concat(second).ToArray();
        }

        private void download_Click(object sender, EventArgs e)
        {
            if (check != 0)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                try
                {
                    ofd.InitialDirectory = "file://DESKTOP-3VE6VUN/server";
                    ofd.ShowDialog();
                    string name = "";
                    name = ofd.FileName;
                    name = name.Substring(name.LastIndexOf('\\') + 1);

                    if (name != "")
                    {
                        NetworkStream ns = tcpClient.GetStream();
                        sendRequestFile = "download/" + name;
                        byte[] data = Encoding.UTF8.GetBytes(sendRequestFile);
                        ns.Write(data, 0, data.Length);
                    }
                }
                catch (Exception) { }
            }
            else MessageBox.Show("Bạn chưa đăng nhập");
        }

        private void quit_Click(object sender, EventArgs e)
        {
            if (check != 0)
            {
                Byte[] data1 = Encoding.UTF8.GetBytes("quit\n");
                ns.Write(data1, 0, data1.Length);
                check = 0;
                connec = 0;
                Thread.Sleep(500);
                tcpClient.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (check != 0)
            {
                if (webBrowser1.CanGoBack)
                {
                    webBrowser1.GoBack();
                    Byte[] data1 = Encoding.UTF8.GetBytes("cwd\n");
                    ns.Write(data1, 0, data1.Length);
                }
            }

        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (check != 0)
            {
                if (webBrowser1.CanGoForward)
                {
                    webBrowser1.GoForward();
                    Byte[] data1 = Encoding.UTF8.GetBytes("cwd\n");
                    ns.Write(data1, 0, data1.Length);
                }
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Byte[] data1 = Encoding.UTF8.GetBytes("cwd\n");
            ns.Write(data1, 0, data1.Length);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (check != 0)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = "file://DESKTOP-3VE6VUN/server";
                ofd.ShowDialog();
                File.Delete(ofd.FileName);
                Byte[] data1 = Encoding.UTF8.GetBytes("delete\n");
                ns.Write(data1, 0, data1.Length);
                MessageBox.Show("Xóa thành công");
                webBrowser1.Url = new Uri("file://DESKTOP-3VE6VUN/server/");
            }
            else MessageBox.Show("Bạn chưa đăng nhập");
        }


        private void encode_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "file:C:/Users/minhN/Desktop";
            MessageBox.Show("Chọn file cần mã hóa");
            try
            {
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string mess = sr.ReadToEnd();
                sr.Close();
                fs.Close();

                sr = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + "key.key");
                string data = sr.ReadToEnd();
                sr.Close();
                byte[] key = Encoding.ASCII.GetBytes(data);

                sr = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + "iv.key");
                data = sr.ReadToEnd();
                sr.Close();
                byte[] iv = Encoding.ASCII.GetBytes(data);

                byte[] buff = Encrypts_Aes(mess, key, iv);

                FileStream fss = new FileStream(ofd.FileName + ".aes", FileMode.Create);
                fss.Write(buff, 0, buff.Length);
                fss.Close();

                MessageBox.Show("Mã hóa thành công");
            }
            catch (Exception) { }
        }

        private void decode_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "file:C:/Users/minhN/Desktop";
            try
            {
                MessageBox.Show("Chọn file cần giải mã");
                ofd.ShowDialog(); 
                string k = ofd.FileName;
                k = k.Replace(".txt.aes", "");

                StreamReader sr = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + "key.key");
                string data = sr.ReadToEnd();
                sr.Close();
                byte[] key = Encoding.ASCII.GetBytes(data);

                sr = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + "iv.key");
                data = sr.ReadToEnd();
                sr.Close();
                byte[] iv = Encoding.ASCII.GetBytes(data);

                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                byte[] buff = new byte[1000000];
                int bytebuff = fs.Read(buff, 0, buff.Length);
                fs.Close();

                fs = new FileStream(ofd.FileName, FileMode.Open);
                byte[] buf = new byte[bytebuff];
                fs.Read(buf, 0, bytebuff);
                fs.Close();

                string mess = Decrypt_Aes(buf, key, iv);

                StreamWriter sw = new StreamWriter(k + "_decode.txt");
                sw.Write(mess);
                sw.Close();
                MessageBox.Show("Giải mã thành công");
            }
            catch (Exception) { }
        }

        public Byte[] Encrypts_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                aesAlg.Padding = PaddingMode.Zeros;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        public string Decrypt_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                aesAlg.Padding = PaddingMode.Zeros;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tcpClient != null)
                tcpClient.Close();
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            new sign().Show();
        }
    }
}
