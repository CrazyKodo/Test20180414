using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Web;


namespace Infrastructure
{
    public class HttpHelper
    {


        static public string request(string url, string postDataStr, int timeout)
        {
            try
            {
                byte[] _byte = System.Text.Encoding.UTF8.GetBytes(postDataStr);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = false;
                request.Method = "POST";
                request.ContentType = "application/json";

                request.ContentLength = _byte.Length;
                request.Timeout = timeout;
                Stream myRequestStream = request.GetRequestStream();
                myRequestStream.Write(_byte, 0, _byte.Length);
                myRequestStream.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                return retString;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                // 发生错误
                // log.Error("【异常】HttpRequest Error:" + ex.Message);
                return "";
            }

        }


        public static string UrlEncode(string src)
        {

            return HttpUtility.UrlEncode(src);
        }

        public static string UrlDecode(string src)
        {

            return HttpUtility.UrlDecode(src);
        }



    }
}
