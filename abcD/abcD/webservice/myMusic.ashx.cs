using abcD.App_Code.DataModel;
using abcD.App_Code.MusicApi;
using abcD.App_Code.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace abcD.webservice
{
    /// <summary>
    /// myMusic 的摘要说明
    /// </summary>
    public class myMusic : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/json";
            List<Song> songlist = MusicApis.SearchApi("linkin park", "1", "0", "10").Cast<Song>().ToList();
            List<onesong> songl = new List<onesong>();
            foreach (Song song in songlist)
            {
                onesong onesong = new onesong();
                onesong.title = song.Name;
                onesong.artist = song.Artist[0].Name;
                onesong.mp3 = song.Mp3Url;
                onesong.poster = song.Album.PictureUrl;
                songl.Add(onesong);
            }

            context.Response.Write(Utils.ObjectToJson(songl));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}