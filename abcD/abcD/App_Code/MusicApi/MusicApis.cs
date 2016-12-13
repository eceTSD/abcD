using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Text;

namespace abcD.App_Code.MusicApi
{
    public class MusicApis
    {
        public MusicApis()
        {

        }
        public string Get_Music()
        {
            string url = "http://music.163.com/api/search/pc";
            string name = "周杰伦";
            
            string postData = "s="+ System.Web.HttpUtility.UrlEncode(name) + "&limit=20&type=1&offset=0";
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Referer = "http://music.163.com/";
            request.Headers.Add("Cookie", "appver=2.0.2");
            request.ContentType = "application/x-www-form-urlencoded";
           
            Stream myRequestStream = request.GetRequestStream();
            StreamWriter sw = new StreamWriter(myRequestStream,Encoding.ASCII);
            sw.Write(postData);
            sw.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader sr = new StreamReader(response.GetResponseStream())) {

                return sr.ReadToEnd().ToString();
                
            }
        }

        public static string get_uft8(string unicodeString)
        {
            UTF8Encoding utf8 = new UTF8Encoding();
            Byte[] encodedBytes = utf8.GetBytes(unicodeString);
            String decodedString = utf8.GetString(encodedBytes);
            return decodedString;
        }
    }

   
}