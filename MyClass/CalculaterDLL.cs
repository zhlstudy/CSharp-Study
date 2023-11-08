using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    public abstract class CalculaterDLL
    {
        //在抽象类中定义  普通的成员变量
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        //构造方法
        public CalculaterDLL() { }
        public CalculaterDLL(double d1,double d2)
        {
            Number1 = d1;Number2 = d2;
        }
        //定义一个抽象方法 ，光说不做
        public abstract double JiSuanResult();
    }

    //2.定义四中计算方法
    public class JiaFa : CalculaterDLL
    {
        public JiaFa() { }
        //.子类调用 父类中的成员字段，并复制
        public JiaFa(double n1,double n2) : base(n1, n2) { }

        public override double JiSuanResult()
        {
            return Number1 + Number2;
        }
    }

    public class JianFa : CalculaterDLL
    {
        public JianFa() { }
        //.子类调用 父类中的成员字段，并复制
        public JianFa(double n1, double n2) : base(n1, n2) { }

        public override double JiSuanResult()
        {
            return Number1 - Number2;
        }
    }

    public class ChengFa : CalculaterDLL
    {
        public ChengFa() { }
        //.子类调用 父类中的成员字段，并复制
        public ChengFa(double n1, double n2) : base(n1, n2) { }

        public override double JiSuanResult()
        {
            return Number1 * Number2;
        }
    }

    public class ChuFa : CalculaterDLL
    {
        public ChuFa() { }
        //.子类调用 父类中的成员字段，并复制
        public ChuFa(double n1, double n2) : base(n1, n2) { }

        public override double JiSuanResult()
        {
            return Number1 / Number2;
        }
    }
}
