using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;

namespace Weather_Application
{
    class Class1
    {
        public String JsonConvert(String url)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(url);
            var response = request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            var json = rd.ReadToEnd();
            return json;
        }
    }
}
