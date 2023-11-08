using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_类的基础复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.类的定义
            //1.什么是类？类的定义
            //   是将不同类型的数据和这些数据相关的操作或行为封闭在一个集合中，这个抽象的集合是叫类
            //   它是一种数据类型，即是自定义的一种数据类类型
            //  int x= 10;
            //2.定义Student类
            //3.类有组成:类的属性(字段)、类的方法、与类名相同构造函数（有参和无参） 也可以没有构造函数，
            //4.类是一种摸具，它是产生对象的摸具




            //2.对象
            //1.类的实列化，对象是类的实列化，是类的具体表现；
            Student s1 = new Student();//定义了一个空对象
            s1.Name = "李氏";

            Student s2 = new Student()
            {
                Name = "王五"
            };
            Student s3 = new Student()
            {
                SId = 100,
                Name = "宋五"
            };
            s1.SayHello();
            s2.SayHello();
            s3.SayHello();

            //让控制台应用程序暂停
            Console.ReadKey();




            //面向对象面向过程
            //1.什么是面向对象？
            //
            //2.什么是面向过程？

            //3.面向对象的三大特征：封装、继承、多态
        }
    }
    public class Student
    {
        //以下是属性字段
        public int SId { get; set; }//读写属性
        public string Name{ get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public int Age { get; set; }
        //2.构造函数
        public Student() { }//默认构造函数
        public Student(string name)
        {
            //有参数的构造函数
            Name = name;
        }
        //3.方法的重载 overload
        public Student(int sId, string name)
        {
            //有参数的构造函数
            SId = sId;
            Name = name;
        }
        //类的方法
        public void SayHello()
        {
            //定义了一个无返回值的方法
            Console.WriteLine(this.Name + "嘿嘿！得学习");
        }
        public void SayHello(string n)
        {
            //定义了一个无返回值的方法
            Console.WriteLine(this.Name + "嘿嘿！得学习 + n");
        }
    }
}
