using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Try_Catch_Finally异常应用
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.try异常处理
            Person p = new Person() { Nationatlity = "中国", Name = "张三", Age = 20 };
            Console.WriteLine("姓名：" + p.Name + "Nationatlity:" + p.Nationatlity);
            //p = null;//在这里挖了一个坑，让你跳
            try
            {
                p.Name = "刘定强";
                Console.WriteLine("当try中有错误发生时，下面的语句 不再被执行了！");
                Console.WriteLine(p.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("错误类型为：" + ex.ToString());
            }
            finally
            {
                //当有finlly时 一定会被执行
                Console.WriteLine("finally被执行了！");
            }
            #endregion
            Console.ReadKey();
        }
    }

    #region 1.try异常处理
    public class Person
    {
        public string Nationatlity { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }


    #endregion

}
