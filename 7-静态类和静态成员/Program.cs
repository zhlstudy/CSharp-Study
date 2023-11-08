using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_静态类和静态成员
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.静态类和静态成员: 修饰符：static
            ////1.静态类的应用
            ////MyClass m = new MyClass();//静态类不能实列化对象
            //MyClass.Name = "张三";
            //MyClass.M1();
            //MyClass.M1("我调用你了");
            #endregion
            #region 2.私有构造函数实例化类的调用方法
            ////1.调用类
            ////MyClass a = new MyClass();
            ////2.用类名直接访问类中的静态成员
            //object mc = MyClass.GetOBject();
            ////3.输出mc的类型是什么
            //((MyClass)mc).SayHello();
            #endregion
            #region 3.实例化普通类中的静态成员
            //Person p = new Person();
            //p.Name = "张三";
            //p.Age = 22;
            //p.Nationatlity = "中国人";
            ////p.Plant = "";//静态成员 不能用对象访问，因为静态成员属于类而不属于实例化对象
            //Person.Planet = "宇宙人";

            #endregion
            #region 4.静态构造函数和静态成员 初始化
            //1.初始化一个对象
            Student st = new Student();
            Console.WriteLine("======上个面有东西输出嘛=========");
            st.SayHello();
            Student.Name = "马化腾";
            Student.SId = "30003";
            Console.WriteLine("姓名："+Student.Name+"SId:"+Student.SId);

            #endregion
            #region 

            #endregion
            Console.ReadKey();
        }
    }
    #region 1.静态类和静态成员: 修饰符：static
    //static class MyClass
    //{
    //    //1.用static修饰的类或成员， 静态类中的成员只能是静态的，不能是实列化成员，
    //    //  普通类中可以有静态成员，这些静态成员属于类而不属于对象；
    //    public static string Name { get; set; }
    //    static int Age { get; set; }
    //    static void MyMethod() { Console.WriteLine("这是一个方法!"); }
    //    //2.静态类不需要实列化的成员变量：字段、构造函数和成员方法；
    //    //public MyClass() { };//静态类不能实列化对象，因此构造 函数没有意义！！有参 无参  都不需要！
    //    //3.静态成员和非静态成员的区别：静态成员 属于类，非静态成员 属于对象
    //    public static void SayHello() { Console.WriteLine("这是静态类中静态方法SayHello()输出的内容!"); }
    //    public static void M1() { Console.WriteLine("这是静态类中静态方法M1()输出的内容!"); }
    //    public static void M1(string str) { Console.WriteLine(str); }//重载了上面的M1方法！
    //}
    #endregion
    #region  2.私有构造函数实例化类的调用方法
    //public class MyClass
    //{
    //    //1.定义  一个私有的构造函数
    //    private MyClass() { }
    //    //2.给这个定义 一个方法, 如何能使用这个类中下面这个方法！！！！！
    //    public void SayHello() { Console.WriteLine("大家好！"); }
    //    //3.定义 一个静态的方法
    //    public static MyClass GetOBject() { return new MyClass(); }
    //}
    #endregion
    #region 3.实例化普通类中的静态成员
    //public class Person
    //{
    //    public string Nationatlity { get; set; }
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public static string Planet { get; set; }
    //    public static void SayHello (string str){ Console.WriteLine(str); }
    //}
    #endregion
    #region 4.静态构造函数和静态成员 初始化
    public class Student
    {
        //1.定义 一静态成员变量
        public static string Name { get; set; }
        public static string SId = "10001";
        public Student() { }
        //2.静态构造 函数的特点
        //   A.静态构造 函数不能有修饰 符，public 不可以
        //   B.静态构造 函数不能手动调用，而且在第一次使用的时候初始化，因为他的private:
        //   C.静态构造 函数只会被执行一次，在第一次使用静态构造函数初始化对象的时候；
        //3.定义初始化构造函数
        static Student()
        {
            Console.WriteLine("1.静态构造函数被执行了！");
            SId = "200002";
            Name = "马玉";
        }
        public void SayHello() { Console.WriteLine("2.SasHello被使用！"); }

    }
    #endregion
    #region 

    #endregion
}
