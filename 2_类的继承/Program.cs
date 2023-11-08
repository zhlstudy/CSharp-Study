using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_类的继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.类的继承
            //1.是指在原有类的基础上，派生出一个新类，即子类，派生 的类叫子类，原来的类叫父类，也叫超类
            //  子类继承父类 的相关的属性成员和方法成员，并且扩展出新的能力或功能
            //2.构造函数能被继承吗？ 构造函数不能被 继承
            //3.类继承的合法性：如何判断一个子类继承父类  是否合法？
            //    子类 is a 父类？
            //4.继承的好处：代码 重用，增加程序的 灵活性，实现 多态；继承的单根性




            //2.类的继承，及实列化对象
            Person p = new Man();
            p.Eating();
            Person p1 = new Student();
            p1.Eating();
            p1.Sleeping();
            ((Student)p1).SayHello();
            ((Student)p1).Studying();
            Console.WriteLine("-------------------------");
            p1 = new Teacher();
            p1.Eating();
            p1.Sleeping();
            ((Teacher)p1).SayHello();
            ((Teacher)p1).Teachering();


            Console.ReadKey(); 

        }
    }
    public class Student : Person
    {
        public int SId { get; set; }
        public string Classes { get; set; }
        public Student() { }
        public Student(int sId, string name, string age)
        {
            this.Name = name;
            this.SId = sId;
            this.Age = age;
        }
        public void SayHello() { Console.WriteLine(this.Name + "嘿嘿，谢特！同学"); }
        public void Studying() { Console.WriteLine(this.Name + "嘿嘿，谢特！你在学习"); }
    }

    public class Teacher : Person
    {
        public int TId { get; set; }
        public string Classes { get; set; }
        public Teacher() { }
        public Teacher(int tId, string name,string age)
        {
            this.Name = name;
            this.TId = tId;
            this.Age = age;
        }
        public void SayHello() { Console.WriteLine(this.Name + "嘿嘿，谢特！老师"); }
        public void Teachering() { Console.WriteLine(this.Name + "嘿嘿，谢特！你在教书"); }
    }

    public class Man : Person
    {
    }



}
