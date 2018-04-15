using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace Infrastructure
{
    public class JsonHelper
    {
        static private JavaScriptSerializer jss = new JavaScriptSerializer();


        public static string Serialize(object obj)
        {
            return jss.Serialize(obj);
        }


        public static T Deserialize<T>(string json)
        {
            return jss.Deserialize<T>(json);
        }


    }
}
