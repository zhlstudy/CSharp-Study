using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_接口及实列程序
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2.子类继承接口 ，子类必须实现 接口的成员方法
            #endregion
            #region 3.接口实现，鸟Birrd 麻雀Sparrow ，海鸥 Swamew，天鹅Swan，企鹅PEnguin 谁会飞  谁会游泳
            //.定义 一个对象
            //IFlyable animal = new IFlyable();// 接口不能实列化对象
            //2.用父类实列化对象指向子类
            //1.能飞的有那些
            //IFlyable animal = new Sparrow();//new Swamew();new Swan();//用接口实现了多态
            //animal.Fiy();
            //Bird bd = new Bird();
            //bd.Bark();
            //bd = new Swamew();
            //Swamew sw = new Swamew();
            //sw.Bark();
            //sw.Fiy();
            //sw.Swim();
            ////((Sparrow)animal).Bark();
            ////1.能游泳的有那些
            //ISwimable animal = new Swamew();//new Swan();
            //animal.Swim();
            #endregion
            #region 4.用实现类：显示信息
            //Chinese ch = new Chinese();
            //ch.ShowInfo();

            #endregion
            #region 5.虚方法现类：显示信息
            //Person2 p = new Chinese();
            //p.ShowInfo();
            #endregion
            #region 6.用抽象类和抽象方法：实现显示信息
            //Person3 p1 = new Chinese { Nationatlity = "中国人", Name = "江苏", Age = 20 };//("中国人", "江苏",20); //
            //p1.ShowInfo();
            #endregion
            #region 7.用接口实现显示 信息
            //IShowInfoable show = new IShowInfoable();//不可以
            IShowInfoable p = new Chinese() { Nationatlity = "中国人", Name = "江苏", Age = 20 };
            p.ShowInfo();
            p = new Amarican();
            p.ShowInfo();
            #endregion
            #region 8.接口间实现
            ISupermanable P3 = new Person4();
            P3.Cycling();
            P3.Running();
            P3.Swiming();
            P3 = new Student4();
            P3.Running();
            P3.Running();
            P3.Swiming();
            #endregion
            Console.ReadKey();


        }
    }
    #region 1.定义  一个接口
    //1.定义一个接口，第一个字母 用I 后面添加able，表示这是一个有什么能力的接口
    //2.接口中只能包含访求名，不能有实现，即不能有方法体程序
    public interface IEatable
    {
        //3.在接口中的方法不能有修饰符，public private，protected，默认是public
        //public void Eat() { Console.WriteLine("我什么都吃！"); }
        //4.接口中的方法不能有实现
        void Eat();
        void Eating(string Who,string What);
        
    }
    #endregion
    #region 2.子类继承接口 ，子类必须实现 接口的成员方法
    public class Student:Person, IEatable
    {
      
        public Student(string name, string gender , int age)
        {
             Name = name;
             Gender = gender;
             Age = age;
        }

        public void Eat()
        {
            Console.WriteLine(this.Name + "同学饿了 要吃 东风西");
        }
        public void Eating(string Who, string What)
        {
            Console.WriteLine(Who + "同学饿了 要吃 东风西"+What +"!!");
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

    }

    #endregion
    #region 3.接口实现，鸟Birrd 麻雀Sparrow ，海鸥Swamew，天鹅Swan，企鹅Penguin 谁会飞  谁会游泳
    //public class Bird { public void Bark() { Console.WriteLine("动物会叫。。。"); } }
    //public interface IFlyable
    //{
    //    void Fiy();
    //}
    //public interface ISwimable
    //{
    //    void Swim();
    //}
    //public class Sparrow : Bird , IFlyable
    //{//麻雀Sparrow
    //    public void Fiy()
    //    {
    //        Console.WriteLine("麻雀笑着在飞");
    //    }

    //}

    //public class Swamew : Bird , IFlyable, ISwimable
    //{//海鸥Seamew
    //    public void Fiy()
    //    {
    //        Console.WriteLine("海鸥在天上飞");
    //    }


    //    public void Swim()
    //    {
    //        Console.WriteLine("海鸥在大海里游泳！");
    //    }
    //}

    //public class Swan : Bird, IFlyable, ISwimable
    //{//天鹅Swan
    //    public void Fiy()
    //    {
    //        Console.WriteLine("天鹅笑着在飞");
    //    }
    //    public void Swim()
    //    {
    //        Console.WriteLine("天鹅在水里游泳");
    //    }
    //}

    //public class Penguin : Bird, ISwimable
    //{//企鹅Penguin

    //    public void Swim()
    //    {
    //        Console.WriteLine("企鹅在游泳");
    //    }
    //}


    #endregion
    #region 4.用实现类：显示信息
    //class Chinese
    //{
    //    public void ShowInfo() { Console.WriteLine("中国人"); }
    //}
    //class Amarican
    //{
    //    public void ShowInfo() { Console.WriteLine("美国人"); }
    //}
    //class German
    //{
    //    public void ShowInfo() { Console.WriteLine("德国人"); }
    //}

    #endregion
    #region 5.虚方法现类：显示信息
    //public class Person2 { public virtual void ShowInfo() { Console.WriteLine("父类中显示"); } }
    //class Chinese:Person2
    //{
    //    public override void ShowInfo() { Console.WriteLine("中国人"); }
    //}
    //class Amarican : Person2
    //    {
    //    public new void ShowInfo() { Console.WriteLine("美国人"); }
    //}
    //class German : Person2
    //    {
    //    public override void ShowInfo() { Console.WriteLine("德国人"); }
    //}

    #endregion
    #region  6.用抽象类和抽象方法：实现显示信息
    //abstract class Person3
    //{
    //    public string Nationatlity { get; set; }
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public abstract void ShowInfo();
    //}
    //class Chinese : Person3
    //{
    //    //public Chinese(string nationatlity, string name, int age)
    //    //{
    //    //    this.Nationatlity = nationatlity;
    //    //    this.Name = name;
    //    //    this.Age = age;
    //    //}
    //    public override void ShowInfo() { Console.WriteLine(Nationatlity+","+Name+","+Age); }
    //}
    //class Amarican : Person3
    //{
    //    public override void ShowInfo() { Console.WriteLine("美国人"); }
    //}
    //class German : Person3
    //{
    //    public override void ShowInfo() { Console.WriteLine(Nationatlity + "," + Name + "," + Age); }
    //}

    #endregion
    #region 7.用接口实现显示 信息
    ////1.定义 一个接口
    //public interface IShowInfoable { void ShowInfo(); }
    //abstract class Person3
    //{
    //    public string Nationatlity { get; set; }
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}
    //class Chinese : Person3,IShowInfoable
    //{
    //    public Chinese()
    //    {
    //    }

    //    public Chinese(string nationatlity, string name, int age)
    //    {
    //        this.Nationatlity = nationatlity;
    //        this.Name = name;
    //        this.Age = age;
    //    }
    //    public  void ShowInfo() { Console.WriteLine(Nationatlity + "," + Name + "," + Age); }
    //}
    //class Amarican : Person3, IShowInfoable
    //{
    //    public  void ShowInfo() { Console.WriteLine("美国人"); }
    //}
    //class German : Person3, IShowInfoable
    //{
    //    public  void ShowInfo() { Console.WriteLine(Nationatlity + "," + Name + "," + Age); }
    //}
    #endregion
    #region 8.接口间实现
    //案列需求：铁人三项赛：能跑，能游泳，能骑自行车
    public interface IRunable { void Running(); }
    public interface ISwimable { void Swiming(); }
    public interface ICylingable { void Cycling(); }
    //1.定义 一个超人
    public interface ISupermanable : IRunable, ISwimable, ICylingable { };
    //2.定义 一个人实现接口
    public class Person4 : ISupermanable
    {
        public void Cycling()
        {
            Console.WriteLine("我能骑自行车");
        }

        public void Running()
        {
            Console.WriteLine("我能跑");
        }

        public void Swiming()
        {
            Console.WriteLine("我能游泳");
        }
    }
    public class Student4 : Person4, ISupermanable
    { }

    #endregion
}
