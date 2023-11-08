using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_用Socket实现简易的聊天程序_客户端
{
   
    public partial class Form1 : Form
    {
        public Socket clientSocket { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btuConn_Click(object sender, EventArgs e)
        {
            //Socket 客户端的逻辑
            //1.创建服务端Socket对象：参数作用
            //   参数1：AddressFamily.InterNetwork:网络寻址方式，代表IP（v4）的协议
            //   参数2: SocketType.Steam:数据传输方式，已流或报文方式：
            //   参数3: ProtocolType.Tcp:设置数据通信的协议，
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket = socket;
            //2.连接服务器
            try
            {
                socket.Connect(IPAddress.Parse(txtSerIP.Text.Trim()), int.Parse(txtserprot.Text.Trim()));
            }
            catch
            {
                MessageBox.Show("连接失败，请重新连接！！！");
            }
            
            //3，连接服务器端发送信息
            AppendTextTotxLog(string.Format("连接服务器:成功！\r\n"));
            Thread thread = new Thread(new ParameterizedThreadStart(RecieveServiceData)) { IsBackground = true };
            thread.Start(clientSocket);
          
            //4.开始接受客户端连接：
            //    QueueUserWorkItem():启动线程池里的一个线程（队列的方式，如线程池暂时没空闲
            //    线程，则进入队列排队），将方法加入队列以便执行，并指定包含该方法所用数据的
            //    对象，此方法在线程池中有线程空闲时被一一执行：Queue -》队列
            //    Accept()一执行，当前线程阻塞，一直等待客户端连接成功
           

        }

        private void AppendTextTotxLog(string txt)
        {
            //在服务端的屏幕上显示客户端的信息
            if (txtLog.InvokeRequired)
            {
                //A.Invoke()和BeginInvoke()
                //Invoke()是同步执行线程，它把封送的访问给线程，但它阻塞所有线程的执行，直到它执行完成后
                //BeginInvoke()是异步执行，他把封送方法给线程，继续执行其他的程序
                //txtLog.Invoke(new Action<string>(s =>
                //{
                //    txtLog.Text = string.Format("{0}\r\n{1}", s, txtLog.Text);
                //}), txt);//定义一个委托后，直接调用            lamda表达式
                txtLog.BeginInvoke(new Action<string>((s) => { txtLog.Text = string.Format("{0}\r\n{1}", s, txtLog.Text); }), txt);
            }
            else { txtLog.Text = string.Format("{0}\r\n{1}", txt, txtLog.Text); }
        }

        private void RecieveServiceData(object obj)
        {
            var clientSocket = (Socket)obj;
            byte[] data = new byte[1024 * 1024];
            while (true)
            {
                int realLen = 0;
                try
                {
                    realLen = clientSocket.Receive(data, 0, data.Length, SocketFlags.None);
                }
                catch (Exception)
                {
                    AppendTextTotxLog(string.Format("服务器端：{0}接受数据异常！非正常退出连接！！！\r\n",
                       clientSocket.RemoteEndPoint.ToString()));                  
                    StopConnect(clientSocket);
                    return;//让线程结束，并返回
                }
                if (realLen <= 0)
                {
                    AppendTextTotxLog(string.Format("服务器端：{0}正常退出了！\r\n",clientSocket.RemoteEndPoint.ToString()));
                    StopConnect(clientSocket);
                    return;//让线程结束，并返回
                }

                #region 1.接受数据成功 ，判断是什么数据？如果是字符串
                if (data[0] == 0)
                {
                    AppendTextTotxLog(string.Format("接受到服务器端：{0}发送的数据：{1}!\r\n\r\n", clientSocket.RemoteEndPoint.ToString(),
                        ProcessRecieveString(data)));
                }
                else if (data[0] == 1)
                {
                    ShakeScreen();
                }
                else if(data[0] == 2)
                {
                    ProcessRevieceFile(data, realLen);
                }
                #endregion
            }

        }

        private void ProcessRevieceFile(byte[] data, int Len)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.DefaultExt = "txt";
                sfd.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
                if (sfd.ShowDialog(this) != DialogResult.OK) return;
                byte[] fileDate = new byte[Len-1];
                Buffer.BlockCopy(data, 1, fileDate, 0, Len - 1);
                File.WriteAllBytes(sfd.FileName, fileDate);
            }
        }

        private void ShakeScreen()
        {
            Point oldLocation = Location;//当前坐标点（100，200）
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Location = new Point(rd.Next(oldLocation.X - 5, oldLocation.X + 5), rd.Next(oldLocation.Y - 5, oldLocation.Y + 5));
                //生成一个新的Point坐标(97，201)
                Thread.Sleep(100);
                Location = oldLocation;
            }
        }

        private string ProcessRecieveString(byte[] data)
        {
            string str = Encoding.UTF8.GetString(data, 1, data.Length - 1);
            return str;
           
        }

        private void StopConnect(Socket proxSt)
        {
            try
            {
                if (proxSt.Connected) { proxSt.Shutdown(SocketShutdown.Both); proxSt.Close(100); }
            }
            catch (Exception) { }
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            if (clientSocket.Connected)
            {
                byte[] data = Encoding.UTF8.GetBytes(txtMsg.Text.Trim());
                clientSocket.Send(data, 0, data.Length, SocketFlags.None);
            }
        }
    }
}
