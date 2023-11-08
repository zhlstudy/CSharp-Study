using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_类的虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.类的虚方法:用virtual 修饰符修饰的方法
                        //虚方法在声明时必须有实现。
            //2.实列化一个对象学生类
            Student st = new Student()
            {
                Name="马云",Age =18,Address ="中国北京",Gender ="女",Nationality ="美国",SId=1002
            };
            st.SayHello();
            st.Sleeping();
            st.Studenting();
            //3.实列化一个对象老师
            Teacher s2 = new Teacher()
            {
                Name = "马云2",
                Age = 18-2,
                Address = "中国北京2",
                Gender = "女2",
                Nationality = "美国2",
                SId = 1002
            };
            st.SayHello();
            st.Sleeping();
            st.Studenting();
        }
        public class Person
        {
            public string Name { get; set; }
            public string Gender { get; set; }
            public string  Address{ get; set; }
            public int  Age{ get; set; }
            public string Nationality { get; set; }
            public Person() { }

            public Person(string name, string gender, string address, int age)
            {
                Name = name; Gender = gender; Address = address; Age = age;
            }
            public virtual void SayHello ()
            {
               // 对Person 对象 集合List<Person> 进行排序的代码
                Console.WriteLine("父类的虚方法");
            }

            public void Eating() { Console.WriteLine("父类的饿方法"); }
            public void Sleeping() { Console.WriteLine("父类的睡方法"); }
        }
        public class Student : Person
        {
            public int  SId { get; set; }
            public Student() { }
            public Student(string name, string gender,string address,string nationavity,int age,int sId)
            {
                Name = name;Gender = gender;Address = address;Nationality = nationavity;Age = age;SId = sId;
            }

            public override void SayHello() { Console.WriteLine("重写的虚方法"); }
            public  void Studenting() { Console.WriteLine(Name +"学生类里面"); }
        }

        public class Teacher : Person
        {
            public int SId { get; set; }
            public Teacher() { }
            public Teacher(string name, string gender, string address, string nationavity, int age, int sId)
            {
                Name = name; Gender = gender; Address = address; Nationality = nationavity; Age = age; SId = sId;
            }

            public override void SayHello() { Console.WriteLine("重写的虚方法"); }
            public void Teachering() { Console.WriteLine(Name + "教师类"); }
        }

    }
}
