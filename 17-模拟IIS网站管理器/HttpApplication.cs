using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_模拟IIS网站管理器
{
    public class HttpApplication:IHttpHandle
    {
        //IIS的核心部分功能封装
        public void ProcessRequest(HttpContext context)
        {
            //获取 到当前网站的目录的路径：D:\C#程序设计\CSharp基础复习\17-模拟IIS网站管理器\bin\Debug
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            //请求报文中的URL地址：/web/3d.html
            string fileName = Path.Combine(basePath, context.Request.Url.Trim('/'));
            //上面的语句执行完后的结果
            //D:\C#程序设计\CSharp基础复习\17-模拟IIS网站管理器\bin\Debug/web/3d.html
            if (!File.Exists(fileName))
            {
                context.Response.StateCode = "404";
                context.Response.StatusDes = "File Not Fround!";
                context.Response.ContentType = "text/html";
                string notExtistFile = Path.Combine(basePath, @"\web\4.html");
                context.Response.Body = File.ReadAllBytes(notExtistFile);
            }
            else
            {
                context.Response.StateCode = "200";
                context.Response.StatusDes = "ok";
                context.Response.ContentType = GetContextType(Path.GetExtension(context.Request.Url));
                //string notExtistFile = Path.Combine(basePath, @"\web\4.html");
                context.Response.Body = File.ReadAllBytes(fileName);
            }
        }

        public void ProcessResquest(HttpRequest Request)
        {
            throw new NotImplementedException();
        }

        private string GetContextType(string ext)
        {
            string type = "text/html;charset=UTF-8";
            switch (ext)
            {
                case ".aspx":
                case ".html":
                case ".htm":
                    type = "text/html,charset=UTF-8";break;
                case ".png":
                    type = "imag/png"; break;
                case ".gif":
                    type = "imag/gif"; break;
                case ".jpg":
                    type = "imag/jpg"; break;
                case ".ico":
                    type = "imag/ico"; break;
                case ".css":
                    type = "text/css"; break;
                case ".js":
                    type = "application/x-javascript"; break;
                default:
                    type = "text/plain;charset=gbk";break;
            }
            return type;
        }
    }

   
}
