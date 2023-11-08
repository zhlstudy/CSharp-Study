using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_类的继承
{
     public  class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public Person() { }
        public void Eating() { Console.WriteLine("父类中定义 在吃！"); }
        public void Sleeping() { Console.WriteLine("在睡！"); }
    }

}
