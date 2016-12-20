﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Text;
using abcD.App_Code.DataModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace abcD.App_Code.MusicApi
{
    public static class MusicApis
    {
        //网易云音乐 搜索接口
        public static string WANGYI_SEARCH = "http://music.163.com/api/search/pc";

        //网易云音乐 歌曲信息
        public static string WANGYI_SONG = "http://music.163.com/api/song/detail/";

        //网易云音乐 歌手专辑信息
        public static string WANGYI_ARTIST = "http://music.163.com/api/artist/albums/";

        //网易云音乐 专辑信息
        public static string WANGYI_ALBUM = "http://music.163.com/api/album/";

        //网易云音乐 歌单信息
        public static string WANGYI_APPLIST = "http://music.163.com/api/playlist/detail";

        //网易云音乐 歌词信息
        public static string WANGYI_LYRIC = "http://music.163.com/api/song/lyric";

        //网易云音乐 mv信息
        public static string WANGYI_VIEW = "http://music.163.com/api/mv/detail";




        /// <summary>
        /// 歌曲搜索
        /// </summary>
        /// <param name="s">搜索关键字</param>
        /// <param name="type">type歌曲 1 专辑 10 歌手 100 歌单 1000 用户 1002 mv 1004 歌词 1006</param>
        /// <param name="offset">分页</param>
        /// <param name="limit">每页显示数目</param>
        /// <returns>返回database基础类型根据类型转换类型</returns>
        public static List<DataBase> SearchApi(string s, string type, string offset, string limit)
        {
            string url = WANGYI_SEARCH;
            string postData = "s=" + System.Web.HttpUtility.UrlEncode(s) + "&limit="+limit+"&type="+type+"&offset="+offset+"";         
            try
            {
                dynamic request = JsonConvert.DeserializeObject(HttpServer.Http_POST(url, postData));
                if (request.code == 200)
                {
                    dynamic result = JsonConvert.DeserializeObject(request.result.ToString());
                    if (type == "1")
                    {                                        
                        return ParseJson.GetSongL(request.songs).Cast<DataBase>().ToList();
                    }
                    else if (type == "10")
                    {                                              
                        return ParseJson.GetAlbumL(request.albums).Cast<DataBase>().ToList();
                    }
                    else if (type == "100")
                    {
                        return ParseJson.GetArtistL(request.artists).Cast<DataBase>().ToList();
                    }
                    else if(type == "1000")
                    {
                        return ParseJson.GetAppListL(request.playlists).Cast<DataBase>().ToList();
                    }
                }

            }
            catch (Exception)
            {
                return new List<DataBase>(0);
            }
            return new List<DataBase>(0);               
        }

        public static string test(string s, string type, string offset, string limit)
        {
            string url = WANGYI_SEARCH;
            string postData = "s=" + System.Web.HttpUtility.UrlEncode(s) + "&limit=" + limit + "&type=" + type + "&offset=" + offset + "";
            return HttpServer.Http_POST(url,postData);
        }



        /// <summary>
        /// 歌曲信息
        /// </summary>
        /// <param name="id">歌曲id</param>
        /// <returns></returns>
        public static string SongInfo(string id){
            string url = WANGYI_SONG + "?id=" + id + "&ids=%5B" + id + "%5D";
            return HttpServer.Http_GET(url);
        }

        /// <summary>
        /// 歌手专辑信息
        /// </summary>
        /// <param name="id">歌手id</param>
        /// <param name="offset">分页</param>
        /// <param name="limit">每页数目</param>
        /// <returns></returns>
        public static string ArtistAlbumInfo(string id,string offset,string limit)
        {          
            string url = WANGYI_ARTIST + id + "?id=" + id + "&total=true&offset=" + offset + "&limit=" + limit;
            return HttpServer.Http_GET(url);
        }

        /// <summary>
        /// 专辑信息
        /// </summary>
        /// <param name="id">专辑id</param>
        /// <param name="offset">分页</param>
        /// <param name="limit">页数</param>
        /// <returns></returns>
        public static string AlbumInfo(string id,string offset,string limit)
        {
            string url = WANGYI_ALBUM + id+"?ext=true&id="+id+"&offset="+offset+"&total=true&limit="+limit;
            return HttpServer.Http_GET(url);
        }

        /// <summary>
        /// 歌单信息
        /// </summary>
        /// <param name="id">歌单id</param>
        /// <returns></returns>
        public static string AppList(string id)
        {
            string url = WANGYI_APPLIST + "?id=" + id + "&updateTime=-1";
            return HttpServer.Http_GET(url);
        }

        /// <summary>
        /// 歌词信息
        /// </summary>
        /// <param name="id">歌词id</param>
        /// <returns></returns>
        public static string LyricInfo(string id)
        {
            string url = WANGYI_LYRIC + "?os=pc&id="+id+"&lv=-1&kv=-1&tv=-1";
            return HttpServer.Http_GET(url);
        }

        /// <summary>
        /// 视频信息
        /// </summary>
        /// <param name="id">视频id</param>
        /// <returns></returns>
        public static string MVInfo(string id)
        {
            string url = WANGYI_VIEW + "?id="+id+"&type=mp4";
            return HttpServer.Http_GET(url);
        }
        

    }
   
}