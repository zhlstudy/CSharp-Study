using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_模拟IIS网站管理器
{
    interface IHttpHandle
    {
        void ProcessResquest(HttpRequest Request);
    }
}
