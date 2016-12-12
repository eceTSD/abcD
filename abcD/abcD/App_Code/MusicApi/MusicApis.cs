using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace abcD.App_Code.MusicApi
{
    public class MusicApis
    {
        public MusicApis()
        {

        }
        public string Get_Music()
        {
            string url = "http://music.163.com/api/song/detail/?id=28377211&ids=%5B28377211%5D";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Referer = "http://music.163.com/";
            request.Headers.Add("Cookie", "appver=1.5.2");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader sr = new StreamReader(response.GetResponseStream())) {

                return sr.ReadToEnd().ToString();
            }
        }
    }
}