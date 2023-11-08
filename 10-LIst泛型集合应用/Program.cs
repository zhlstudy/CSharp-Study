using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_LIst泛型集合应用
{
    class Program
    {
        static void Main(string[] args)
        {
            //A.List<T>.泛型集合：T可以是以任意类型的数据，如Int string person类对象集合 ，bool
            //B.它也叫泛型约束集合 List<Person> lst=new List<Person> ；这里只能放Person类对象
            //C.ArraryList和List<T>的区别：如：一筐水果和一筐苹果的区别：
            //D.List<T>的好处：确保集合中的数据类型的一致性
            #region 1.泛型集合Dictionary<Key ,value>键值对集合或字典类型数据
            //1.键值对数中，key表示 键，value 表示键对应的值；
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "马云");
            dict.Add(2, "li云");
            dict.Add(3, "z云");
            Console.WriteLine(dict[2]);
            Console.WriteLine("=================================================");
            //2.获取 键
            foreach (var item in dict.Keys) { Console.WriteLine(item); }
            //3.获取 值
            foreach (var item in dict.Values) { Console.WriteLine(item); }
            //3.获取 值
            foreach (KeyValuePair<int,string> item in dict) { Console.WriteLine(item.Key+"->"+item.Value); }
            //作业：把person类的对象添加到一个键值对中，记录有三个
            #endregion
            Console.WriteLine("=================================================");
            #region 2.泛型集合Dictionary<Key ,value>-----练习1
            //1.需求：把0123456789 转换为一二三四五六七八九十，
            string str = "1一,2二,3三,4四,5五,6六,7七,8八,9九";
            //2.定义 一键值对集合
            Dictionary<char, char> dic = new Dictionary<char, char>();
            //3.分割字符串数据到数组中
            string[] strArr = str.Split(',');
            //4.把数组添加到字典中
            for (int i = 0; i < strArr.Length; i++)
            {
                dic.Add(strArr[i][0], strArr[i][1]);
            }
            //5.获取键盘输入的数字
            StringBuilder sd = new StringBuilder();
            Console.WriteLine("请输入0-9之间的数字：");
            String subStr = Console.ReadLine();
            //6.输出
            for (int i = 0; i < subStr.Length; i++)
            {
                sd.Append(dic[subStr[i]]);
            }
            Console.WriteLine(sd.ToString());

            #endregion
            Console.WriteLine("=================================================");
            #region 3.泛型约束集合List<T>的应用
            //定义 一个List<T>集合
            List<int> intList = new List<int>() { 92, 3, 564, 757, 58, 897, 9, 679, 7, 6, 56 };
            intList.Sort();

            #endregion
            #region 4.泛型约束集合List<T>-----练习1
            //1.需求：把一个数列 分 奇偶数排列，偶数在前，奇数在后
            string str4 = "12,5,76,23,4,56,7,86,55,45,32,44";
            //2.分割字符串数据到数组中
            string[] strList = str.Split(',');
            //3.定义 第二个list<int>集合，分别 用存放偶数列 和奇数序列
            List<string> intOdd = new List<string>();//奇数
            List<string> intEven = new List<string>();//偶数
            for (int i = 0; i < strList.Length; i++)
            {
                if (Convert.ToInt16(strList[i]) % 2 == 0) { intEven.Add(strList[i]); }
                else intOdd.Add(strList[i]);
            }
            //4.合并 两个集合
            intOdd.AddRange(intEven);
            for (int i = 0; i < intOdd.Count; i++)
            {
                Console.WriteLine(intOdd[i]+",");

            }
            #endregion
            Console.WriteLine("=================================================");
            #region 6.定义一个泛型约束集合List<Person>
            //1.定义 一个Person类泛型约束集合
            List<Person> personList = new List<Person>();
            //2.给集合添加
            Person A = new Person() { Name = "张三", Age = 19, Email = "127@qq.com" };
            personList.Add(A);
            A = new Person() { Name = "李氏", Age = 19, Email = "127@qq.com" };
            personList.Add(A);
            A = new Person() { Name = "王五", Age = 16, Email = "217@qq.com" };
            personList.Add(A);
            A = new Person() { Name = "周六", Age = 32, Email = "188@qq.com" };
            personList.Add(A);
            A = new Person() { Name = "周天", Age = 21, Email = "677@qq.com" };
            personList.Add(A);
            foreach (Person item in personList)
            {
                Console.WriteLine("xingming； " + item.Name + "age:" + item.Age);
            }
            #endregion
            #region

            #endregion
            Console.ReadKey();
        }
    }

     class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
