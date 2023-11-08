using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_模拟IIS网站管理器
{
     public class HttpResponse
    {
        //这个类的作用
        public string StateCode { get; set; }

        public string StatusDes { get; set; }

        public string ContentType { get; set; }

        public byte[] Body { get; set; }

        public byte[] GetResponseHeader()
        {
            string strResponseStr = string.Format(@"HTTP/1.1 {0} {1}
Contene-Type: {2} 
Accept-Ranges: bytes
Service: Microsoft-IIS/10.0
X-Powered-By: ASP.NET
Date: Thu, 16 Mar 2023 07:31:46 GMT
Content-Length: {3}

", StateCode, StatusDes, ContentType, Body.Length);
            return Encoding.Default.GetBytes(strResponseStr);
        }
    }
}
