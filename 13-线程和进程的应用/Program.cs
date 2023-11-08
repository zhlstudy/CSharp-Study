using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _13_线程和进程的应用
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.线程的概念极实例化对象
            ////1.线程的命名空间：using system.threading;
            ////2.用Thread定义一个线程对象
            ////  Thread td = new Thread(MyMethod);//定义一个线程对象时 必须有一个参数  ThreadStart

            ////3.ThreadStart 是一个委托,用Lambda表达式写
            //Thread td = new Thread(()=> {
            //    while (true)
            //    {
            //        Console.WriteLine(DateTime.Now);
            //        Thread.Sleep(500);
            //    } 
            //});
            ////
            //td.IsBackground = true;//它是一个默认的后台线程

            //td.Start();
            ////td.Abort();停了
            #endregion
            #region 2.主线程和创建的线程
            //while(true)
            //{
            //    Console.WriteLine("---这是Main主线程---");
            //    Thread.Sleep(500);
            //}
            #endregion
            #region 3.线程的主要属性
            //Thread td = new Thread(() =>
            //{
            //    while (true)
            //    {
            //        Console.WriteLine(DateTime.Now);
            //        Thread.Sleep(500);
            //    }
            //});
            ////td.Priority = ThreadPriority.Highest;//告诉进程 建议提高这个线程的优先级为最高 他进程不一定理会
            ////td.IsBackground = true;//它是一个默认的后台线程
            ////td.Join();
            ////td.Start();
            //////td.Abort();停了
            //Console.WriteLine("进程Id" + td.ManagedThreadId.ToString());
            //Console.WriteLine("这是Main主线程ID" + Thread.CurrentThread.ManagedThreadId.ToString());
            //td.Start();
            #endregion

            #region 4.获取当前进程中的数据
            //var allProcess = Process.GetProcesses();//Process是一个可实例化，但GetProcess()是一个静态的方法
            //Console.WriteLine("进程名  -----    进程Id");
            //foreach (var item in allProcess)
            //{
            //    Console.WriteLine(item.ProcessName + "------" + item.Id);
            //}
            //Console.WriteLine();


            #endregion

            #region 5.启动一个记事本的进程
            //Process.Start("notepad.exe","MyNotepad");
            //作业启动Excel
            Process.Start("Excel.exe");
            #endregion

            #region 

            #endregion

            Console.ReadKey();
        }

        //private static void MyMethod()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine(DateTime.Now);
        //        Thread.Sleep(500);
        //    }
        //}
    }
}
