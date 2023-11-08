using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_模拟IIS网站管理器
{
    public class HttpRequest
    {
        //请求报文  requestStr
        public HttpRequest(String requestStr)
        {
            //这个类的作用是：解析客户端的请求报文并封装到对象中；
            //1.requestStr中的信息是客户端发送的请求报文内容，它的格式是：
            //  每行都是已\r\n作为结束
            //  请求行有三个部分组成
            //2.把请求报文分割为数组 数据
            var lines = requestStr.Replace("\r\n", "\n").Split('\n');
            //3.数组第一行是请求报文的方法、Url地址和Http版本号
            //  分别获取这三个数据并赋值给类的三个属性字段；            
            HttpMethod = lines[0].Split(' ')[0];
            Url = lines[0].Split(' ')[1];
            HttpVersion= lines[0].Split(' ')[2];
            //4.以上完成了对客户端请求报文的解析和封装；
        }
        public string HttpMethod { get; set; }

        public string Url { get; set; }

        public string HttpVersion { get; set; }

        public Dictionary<string, string> HeaderDict { get; set; }

        public Dictionary<string, string> BodyDict { get; set; }
    }
}
