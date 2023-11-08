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

namespace _15_用Socket实现简易的聊天程序_服务器端
{
    public partial class ChatService : Form
    {
        List<Socket> clientProxsocetList = new List<Socket>();
        public ChatService()
        {
            InitializeComponent();
            //Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btuStart_Click(object sender, EventArgs e)
        {
            //Socket 服务端的逻辑
            //1.创建服务端Socket对象：参数作用
            //   参数1：AddressFamily.InterNetwork:网络寻址方式，代表IP（v4）的协议
            //   参数2: SocketType.Steam:数据传输方式，已流或报文方式：
            //   参数3: ProtocolType.Tcp:设置数据通信的协议，
            Socket svSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //2.绑定IP端口
            IPAddress ip = IPAddress.Parse(txtIP.Text.Trim());
            IPEndPoint ipP = new IPEndPoint(ip,int.Parse(txtprot.Text.Trim()));
            svSocket.Bind(ipP);
            //3，开启侦听
            svSocket.Listen(50);
            //4.开始接受客户端连接：
            //    QueueUserWorkItem():启动线程池里的一个线程（队列的方式，如线程池暂时没空闲
            //    线程，则进入队列排队），将方法加入队列以便执行，并指定包含该方法所用数据的
            //    对象，此方法在线程池中有线程空闲时被一一执行：Queue -》队列
            //    Accept()一执行，当前线程阻塞，一直等待客户端连接成功
            ThreadPool.QueueUserWorkItem(new WaitCallback(StartAcceptClient),svSocket);//开启A线程 有一个方法
        }

        private void StartAcceptClient(object sct)
        {
            //开始接收客户端的连接
            Socket svSocket = (Socket)sct;
            Socket proxSocket = null;//临时的客户对象！
            //txtLog.Text = "服务器开始接收客户端的请求连接........\r\n" + txtLog.Text.Trim();
            AppendTextTotxLog(string.Format("服务器开始接收客户端的请求连接........\r\n"));
            while (true)
            {
                try
                {
                    proxSocket = svSocket.Accept();
                }
                catch(Exception ex)
                {
                    AppendTextTotxLog(string.Format("客户端：{0}连接异常{1}！\r\n",
                        proxSocket.RemoteEndPoint.ToString(), ex));
                    //定义了一个
                    clientProxsocetList.Remove(proxSocket);//清除
                    StopConnect(proxSocket);
                    return;//让线程结束，并返回
                }
                AppendTextTotxLog(string.Format("客户端：{0}连接成功！\r\n",
                        proxSocket.RemoteEndPoint.ToString()));
                clientProxsocetList.Add(proxSocket);
                ThreadPool.QueueUserWorkItem(new WaitCallback(RecieveData), proxSocket);//回调函数 delegate委托 调用一个方法 在开启一个线程B
            }
        }

        private void RecieveData(object state)
        {
            Socket proxSocket = (Socket)state;
            //定义一个1M临时的数据缓冲区
            byte[] data = new byte[1024 * 1024];
            while (true)
            {
                int realLen = 0;
                try
                {
                    realLen = proxSocket.Receive(data, 0, data.Length, SocketFlags.None);
                }
                catch(Exception)
                {
                    AppendTextTotxLog(string.Format("客户端：{0}数据接受发生异常！退出连接！！！\r\n",
                       proxSocket.RemoteEndPoint.ToString()));
                    clientProxsocetList.Remove(proxSocket);//清除
                    StopConnect(proxSocket);
                    return;//让线程结束，并返回
                }
                if (realLen == 0)
                {
                    AppendTextTotxLog(string.Format("客户端：{0}正常退出了！\r\n",
                      proxSocket.RemoteEndPoint.ToString()));
                    clientProxsocetList.Remove(proxSocket);//清除
                    StopConnect(proxSocket);
                    return;//让线程结束，并返回
                }
                string msg = Encoding.UTF8.GetString(data, 0, realLen);
                AppendTextTotxLog(string.Format("接受客户端：{0}发送信息了{1}！\r\n\r\n",
                    proxSocket.RemoteEndPoint.ToString(),msg));
            }
        }

        private void StopConnect(Socket proxSt)
        {
            try
            {
                if (proxSt.Connected) { proxSt.Shutdown(SocketShutdown.Both); proxSt.Close(100); }
            }
            catch (Exception) { }
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
                txtLog.BeginInvoke(new Action<string>((s) => {  txtLog.Text = string.Format("{0}\r\n{1}", s, txtLog.Text); }), txt);
            }
            else { txtLog.Text = string.Format("{0}\r\n{1}", txt, txtLog.Text); }
            
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            // byte[] data = Encoding.UTF8.GetBytes(txtMsg.ToString().Trim());
            byte[] data = Encoding.UTF8.GetBytes(txtMsg.Text.Trim());
            byte[] result = new byte[data.Length + 1];
            result[0] = 0;
            foreach (Socket item in clientProxsocetList)
            {
                if (item.Connected)
                {
                    //                         srcOffset偏移量  
                    //BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count);
                    Buffer.BlockCopy(data, 0, result, 1, data.Length);
                    item.Send(result,0,result.Length,SocketFlags.None);
                }
            }
        }

        private void btnSendShhape_Click(object sender, EventArgs e)
        {
            foreach (Socket scoket in clientProxsocetList)
            {
                if (scoket.Connected) { scoket.Send(new byte[] { 1,1,2 }); };
            }
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd=new OpenFileDialog())
            {
                if (ofd.ShowDialog() != DialogResult.OK) return;
                byte[] data = File.ReadAllBytes(ofd.FileName);
               
                byte[] result = new byte[data.Length + 1];
                result[0] = 2;
                
                foreach (Socket scoket in clientProxsocetList)
                {
                    //                         srcOffset偏移量  
                    //BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count);
                    Buffer.BlockCopy(data, 0, result, 1, data.Length);
                    scoket.Send(result, 0, result.Length, SocketFlags.None);
                }
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
