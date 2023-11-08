using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myclass
{
    

    public interface ICountable
    {
        double Jiafa();
        double Jianfa();
        double Chengfa();
        double Chufa();
    }
   
    public class JiSuan : ICountable
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public double Chengfa()
        {
            return Number1 * Number2;
        }

        public double Chufa()
        {
            return Number1 / Number2;
        }

        public double Jiafa()
        {
            return Number1 + Number2;
        }

        public double Jianfa()
        {
            return Number1 - Number2;
        }
    }

}
