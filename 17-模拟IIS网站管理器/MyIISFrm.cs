using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_模拟IIS网站管理器
{
    public partial class MyIISFrm : Form
    {
        List<Socket> clientProxsocetList = new List<Socket>();
        public MyIISFrm()
        {
            InitializeComponent();
        }

        private void btuStart_Click(object sender, EventArgs e)
        {
            //Socket 服务端的逻辑
            Socket svSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //2.绑定IP端口
            svSocket.Bind(new IPEndPoint(IPAddress.Parse(txtIP.Text.Trim()), int.Parse(txtprot.Text.Trim())));
            //3，开启侦听
            svSocket.Listen(50);
            //4.开始接受客户端连接：            
            ThreadPool.QueueUserWorkItem(new WaitCallback(StartAcceptClient), svSocket);//开启A线程 有一个方法
        }

        private void StartAcceptClient(object sct)
        {
            //开始接收客户端的连接
            Socket svSocket = (Socket)sct;           
            AppendTextTotxLog(string.Format("服务器开始接收客户端的请求连接........\r\n"));
            while (true)
            {
                int realLen;
                Socket proxSocket = svSocket.Accept();
                byte[] data = new byte[1024 * 1024 * 10];

                try
                {
                    realLen = proxSocket.Receive(data,0,data.Length,SocketFlags.None);
                }
                catch (Exception ex)
                {
                    AppendTextTotxLog(string.Format("客户端：{0}连接异常{1}！\r\n",
                        proxSocket.RemoteEndPoint.ToString(), ex));                                     
                    //StopConnect(proxSocket);
                    return;//让线程结束，并返回
                }
                string requestStr = Encoding.UTF8.GetString(data, 0, realLen);
                AppendTextTotxLog(string.Format("时间：{0} 接收到客户端：{1} 发送的请求报文信息：\r\n{2}",
                    DateTime.Now.ToShortTimeString(), proxSocket.RemoteEndPoint.ToString(), requestStr));

                HttpContext context = new HttpContext(requestStr);
                HttpApplication app = new HttpApplication();
                app.ProcessRequest(context);

                proxSocket.Send(context.Response.GetResponseHeader());
                proxSocket.Send(context.Response.Body);
                string str = Encoding.UTF8.GetString(context.Response.GetResponseHeader());
                AppendTextTotxLog(string.Format("时间：{0} 服务端发回响应报文：\r\n{1}",
                   DateTime.Now.ToShortTimeString(),str));
                proxSocket.Shutdown(SocketShutdown.Both);
                proxSocket.Close();



            }
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

       

    }
}
