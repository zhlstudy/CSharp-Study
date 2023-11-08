using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_模拟IIS网站管理器
{
    public class HttpContext
    {
        public HttpRequest Request { get; set; }

        public HttpResponse Response { get; set; }

        public HttpContext(string requestTxt)
        {
            Request = new HttpRequest(requestTxt);
            Response = new HttpResponse();
        }
    }
}
