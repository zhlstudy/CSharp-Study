using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ArrayList集合实例
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.数组和集合的区别
            //1.数组：是类型相同的一组相关数据的集合，
            String[] nameArr = new string[] { "张三","李氏","王五"};
            int[] numArr = new int[] {1,2,3,4,5,6,7,8,9 };
            //数组声明后，长度固定，而集合的长度不固定，自增长
            //数组 中存放的长度时一级数据相同的元素，而集合ArrayList集合可以放不同类型的数据
            //数组 中长度计算Length，而集合长度计算用：count


            //数组声明后，长度固定，
            Console.WriteLine(nameArr.Length);
            //遍历
            //foreach (var item in nameArr)
            //{
            //    Console.WriteLine(item);
            //}                  //数组 中长度计算Length，而集合长度计算用：count       
            //for (int i = 0; i < arList.Count; i++)
            //{
            //    Console.WriteLine(arList[i]);
            //}
            //numArr.Sort();//数组没有 自动排序 的功能 ，集合有
            #endregion
            #region 2.ArrayList集合的使用
            //1.集合的概念:  具有相互关联的一组数据序列，叫做集合，C#中常用的集合有：
            //ArrarList,List<T>,Dictionary<key,values>键值对 集合，在这三个集合中最常用的集合时List<T>泛型约束集合
            //2.定义 一个集合IQuerayable集合.ToList();List<StudentCj>  集合容量：自增长
            ArrayList arList = new ArrayList();
            //3.查看集合的元素个数和容量
         //   Console.WriteLine("arrList集合的个数：{0}，容量：{1}", arList.Count, arList.Capacity);
            //4.给集合 添加 元素
            arList.Add(20);arList.Add(18.88);arList.Add("江苏");
            Console.WriteLine("arrList集合的个数：{0}，容量：{1}", arList.Count, arList.Capacity);
            //5.添加元素  一样的
            //6.添加 一个Person类定义对象
            Person p = new Person() { Name = "张三", Age = 19, Email = "127@qq.com" };
            #endregion
            #region 3.集合的增删改查操作
            //1.向集合 的指定 的位置添加 一个元素
            arList.Insert(2, p);
            for (int i = 0; i < arList.Count; i++)
            {
                Console.WriteLine(arList[i]);
            }
            Console.WriteLine("arrList集合的个数：{0}，容量：{1}", arList.Count, arList.Capacity);
            Person p1 = (Person)arList[2];
            Console.WriteLine("姓名："+p1.Name+"Age:"+p1.Age);

            //2.把一个数组 添加 到集合中
            arList.AddRange(new int[] { 1, 2, 3, 4, 5, 6, });
            Console.WriteLine("arrList集合的个数：{0}，容量：{1}", arList.Count, arList.Capacity);

            //3.删除指定值元素                     
            arList. Remove(20);
            for (int i = 0; i < arList.Count; i++)
            {
                Console.WriteLine(arList[i]);
            }
            //4.指定位置RemoveAt()
            //5.指定范围RemoveRange()
            #endregion
            #region 作业
            //移除元素
            Console.WriteLine("===================求奇数==========================");
            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    arrayList.RemoveAt(i);
            //}
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item.ToString() + ",");
            //}
            //Console.WriteLine("======================下面是作业：留奇数===================");
            //作业：留奇数
            //for (int i = 1; i < arrayList.Count; i++)
            //{
            //    arrayList.RemoveAt(i);
            //}
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item.ToString() + ",");
            //}
            #endregion


            #region 4.集合ArrsyList--练习2
            //1.需求：使用ArrayList集合的排序-Sort()方法
            Console.WriteLine("=====================排序========================");
            ArrayList arrayList = new ArrayList() { 18, 92, 333, 4, 51, 166, 77, 8, 59, 100 };
            arrayList.Sort();
            arrayList.Reverse();//反转
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i] + ",");
            }
            Console.WriteLine();
            #endregion
            #region 4.随机产生1--10之间的数，放入集合要求全部是偶数，且不能有重复
            Console.WriteLine("=====================4.========================");
            ArrayList ramList = new ArrayList();
            Random rd = new Random();
            int n = 0;
            while (n < 10)
            {
                int num = rd.Next(200,301);
                if (num % 2 == 0 && !ramList.Contains(num))
                {
                    ramList.Add(num);n++;
                }
            }
            for (int i = 0; i < ramList.Count; i++)
            {
                Console.WriteLine(ramList[i]);
            }
            #endregion
            #region 5.定义一个Person集合
            Console.WriteLine("=====================降序.========================");
            ArrayList personList = new ArrayList();
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
            //personList.Sort();//报错 应为person是一个自定义类  没有实现
            //foreach (Person item in personList)
            //{
            //    Console.WriteLine("xingming； " + item.Name + "age:" + item.Age);
            //}
            #endregion
            #region 6.进阶1：实现 Person 的自动排序
            //1.定义 一个实现类 ，并继承接口IComparable接口中的COmpareTo()方法
            personList.Sort();
            personList.Reverse();//降序
            foreach (Person item in personList)
            {
                Console.WriteLine("xingming； " + item.Name + "age:" + item.Age);
            }

            #endregion
            #region 7.进阶2，自定义 一个排序初始化器， 实现Icompare
            Console.WriteLine("=================== 进阶2==========================");
            //1.定义 一个类的比较器
            personList.Sort(new SorteByPersonAge());
            //personList.Sort(new SorteByPersonName());
            foreach (Person item in personList)
            {
                Console.WriteLine("xingming； " + item.Name + "age:" + item.Age);
            }

            #endregion

            Console.ReadKey();
        }
    }


    class Person :IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public int CompareTo(object obj)
        {    //6.进阶
            Person A =obj as Person;
            if (A != null) { return this.Age - A.Age; }//升序
            //if (A != null) { return this.Name.CompareTo(A.Name); }//升序
            return 0;
        }
    }
    
    //7.进阶2
    internal class SorteByPersonAge : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x != null && y != null)
            {
                Person p1 = x as Person;
                Person p2 = y as Person;
                return p1.Age - p2.Age;

                return 0;
        }
    }
}
