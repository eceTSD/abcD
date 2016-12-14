using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Text;

namespace abcD.App_Code.MusicApi
{
    public abstract class MusicApis
    {
        //网易云音乐 搜索接口
        public static string WANGYI_SEARCH = "http://music.163.com/api/search/pc";

        //网易云音乐 歌曲信息
        public static string WANGYI_SONG = "http://music.163.com/api/song/detail/";

        //网易云音乐 歌手信息
        public static string WANGYI_ARTIST = "http://music.163.com/api/artist/albums/";

        //网易云音乐 专辑信息
        public static string WANGYI_ALBUM = "http://music.163.com/api/album/";

        //网易云音乐 歌单信息
        public static string WANGYI_APPLIST = "http://music.163.com/api/playlist/detail";

        //网易云音乐 歌词信息
        public static string WANGYI_LYRIC = "http://music.163.com/api/song/lyric";

        //网易云音乐 mv信息
        public static string WANGYI_VIEW = "GET http://music.163.com/api/mv/detail";





        public static string Search_Api(string s, string type, string offset, string limit)
        {
            string url = WANGYI_SEARCH;
            string postData = "s=" + System.Web.HttpUtility.UrlEncode(s) + "&limit="+limit+"&type="+type+"&offset="+offset+"";
            return HttpServer.Http_POST(url, postData);
        }

        public static string Song_Info(string id){
            string url = WANGYI_SONG + "?id=" + id + "&ids=%5B" + id + "%5D";
            return HttpServer.Http_GET(url);

        }


    }
   
}