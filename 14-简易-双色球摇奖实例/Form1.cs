using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_简易_双色球摇奖实例
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            //第一个
           // Control.CheckForIllegalCrossThreadCalls = false;
        }
        //定义一个集合
        private List<Label> IbList = new List<Label>();

        private bool isRuning = false;

       

        private void MainFrm_Load(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 8; i++)
            {
                Label Ib = new Label
                {
                    Text = "0",//i.ToString();// "0"
                    AutoSize = true,
                    Font = new Font("宋体", 20),
                    ForeColor = Color.Red,
                    Location = new Point(50 * i + 70, 150)
                };
                this.Controls.Add(Ib);                
                IbList.Add(Ib);

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isRuning = true;
            Random rd = new Random();
            Thread tb = new Thread(() =>
            {
                #region 1.不允许线程间进行访问
                //while (isRuning)
                //{
                //    foreach (var item in IbList)
                //    {
// Control.CheckForIllegalCrossThreadCalls = false;   
                //        item.Text = rd.Next(0,10).ToString();
                //    }
                //}
                //Thread.Sleep(500);
            #endregion

            #region 2.允许跨线程访问
            while (isRuning)
                {
                    foreach (var item in IbList)
                    {
                        string str = rd.Next(0, 10).ToString();
                        if (item.InvokeRequired)
                        {
                            //A.Invoke()和BeginInvoke()
                            //Invoke()是同步执行线程，它把封送的访问给线程，但它阻塞所有线程的执行，直到它执行完成后
                            //BeginInvoke()是异步执行，他把封送方法给线程，继续执行其他的程序
                            item.Invoke(new Action<string>((s) => { item.Text = s; }),str);//定义一个委托后，直接调用
                            //item.BeginInvoke(new Action<string>((s) => { item.Text = s; }), str);
                        }
                        else item.Text = str;
                        
                    }
                    Thread.Sleep(100);
                }
                
                #endregion
            });
            tb.IsBackground = true;//它是一个默认的后台线程
            tb.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isRuning = false;
        }
    }
}
