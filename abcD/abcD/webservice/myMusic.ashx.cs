﻿using abcD.App_Code.DataModel;
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

            string s = context.Request.Params["s"] == null ? "" : context.Request.Params["s"].ToString();
           if (s == "") { s = "Joe Satriani"; }
            context.Response.ContentType = "text/json";
             List<Song> songlist = MusicApis.SearchApi(s, "1", "0", "20").Cast<Song>().ToList();
            List<onesongnew> songl = new List<onesongnew>();
            foreach (Song song in songlist)
            {
                onesongnew onesong = new onesongnew();
                onesong.title = song.Name;
                onesong.author = song.Artist[0].Name;
                onesong.url = song.Mp3Url;
                onesong.pic = song.Album.PictureUrl;
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