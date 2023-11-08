using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_抽像类及其多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.抽像类的定义：用abstract关键字修饰的类
            //2.抽像 类不能实例化对象，光说不练，抽像类可有普通的成员
            //抽象方法  
            //3.抽象类只能被子类继承，
            //4.子类继承抽像父类后，必须 重写抽象父类 中的方法 ，override关键字
            //5.子类重写抽象父类中的方法，即实现了类的多态
            //6.抽象类的可以有实列化成员，也可没抽象成员；
            //7.当定义有参的方法时，尽量用父类的参数传递，当方法有返回值时，最好用父类的类型作为返回值 的类型

            #region 1.定义对象
            //Dog dog = new Dog("拉布拉多","黑白色");
            //dog.Bark();
            //dog.Eat();
            //dog.Sleeping();

            //Console.WriteLine("==============================");

            //Cat  cat = new Cat("招财进宝", "灰色");
            //cat.Bark();
            //cat.Eat();
            //cat.Sleeping();

            //Console.ReadKey();
            //#endregion
            #endregion
            #region 2.用父类定义 对象
            // Animal animal = new Animal(); 抽像 类不能实例化对象
            //Animal animal = new Dog();//父类对象 指向 子类对象，实现 类的多态
            //animal.Bark();
            //animal.Eat();
            //animal.Sleeping();
            //Console.WriteLine("==============================");
            //animal = new Cat("招财进宝", "灰色");
            //animal.Bark();
            //animal.Eat();
            //animal.Sleeping();

            //Console.WriteLine("==============================");
            //animal = null;
            //animal.Bark();
            //animal.Eat();
            //animal.Sleeping();
            //Console.ReadKey();
            #endregion

            #region 3.强制 转换
            Animal animal = new Dog("拉布拉多", "黑白色");
            //animal.Bark();
            //animal.Eat();
            //animal.Sleeping();
            ((Cat)animal).Bark();//我想让它猫叫
            ((Cat)animal).Eat ();
            Console.ReadKey();
            #endregion
        }


        //定义 一个抽象类 动物 小狗  小猫
        public abstract class Animal
        {
            public string Name { get; set; }
            public string AnimalColor { get; set; }

            public abstract void Eat();//定义 一个抽象 方法，抽象 方法不能有实现
            public abstract void Bark();//光说不做的抽象 方法，子类继承时，必须用override的方法重写这个 成员方法
            public  void Sleeping() { Console.WriteLine("这是一个实列化对象 的成员方法"); }
        }

        public class Dog : Animal
        {
            public Dog() { }
       
            public Dog(string name, string animalcolor)
            {
                this.Name=name ;this.AnimalColor = animalcolor;
            }
            public override void Bark()
            {
                Console.WriteLine(this.AnimalColor+"的名字是：" + this.Name+"的小狗汪汪叫！！");
              // throw new NotImplementedException();
            }

            public override void Eat()
            {
                Console.WriteLine(this.AnimalColor + "的名字是：" + this.Name + "的小狗在吃东西！！");
               // throw new NotImplementedException();
            }
        }

        public class Cat : Animal
        {
            public Cat(string name, string animalcolor)
            {
                this.Name = name; this.AnimalColor = animalcolor;
            }
            public override void Bark()
            {
                Console.WriteLine(this.AnimalColor + "的名字是：" + this.Name + "的小猫汪汪叫！！");
            }

            public override void Eat()
            {
                Console.WriteLine(this.AnimalColor + "的名字是：" + this.Name + "的小猫在吃东西！！");
            }
        }
    }
}
