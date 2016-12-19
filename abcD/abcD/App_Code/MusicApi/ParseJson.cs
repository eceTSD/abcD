using abcD.App_Code.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace abcD.App_Code.MusicApi
{
    public class ParseJson
    {

        /// <summary>
        /// 解析单个歌曲
        /// </summary>
        /// <param name="songJson"></param>
        /// <returns></returns>
        public static Song GetSong(string songJson)
        {

            dynamic songJ = JsonConvert.DeserializeObject(songJson);

            Song song = new Song();
            return song;
        }

        /// <summary>
        /// 解析歌曲列表
        /// </summary>
        /// <param name="jarry"></param>
        /// <returns></returns>
        public static List<Song> GetSongL(JArray jarry)
        {            
            List<Song> SongList = new List<Song>();
            for(int i = 0; i < jarry.Count; i++)
            {
                SongList.Add(GetSong(jarry.ElementAt(i).ToString())); 
            }
           
            return SongList;
        }

        /// <summary>
        /// 解析单个歌单
        /// </summary>
        /// <param name="appListJson"></param>
        /// <returns></returns>
        public static AppList GetAppList(string appListJson)
        {
            dynamic appListj = JsonConvert.DeserializeObject(appListJson);
            AppList appList = new AppList();

            return appList;
        }

        /// <summary>
        /// 解析歌单列表
        /// </summary>
        /// <param name="jarry"></param>
        /// <returns></returns>
        public static List<AppList> GetAppListL(JArray jarry)
        {
            List<AppList> appList = new List<AppList>();
            for (int i = 0; i < jarry.Count; i++)
            {
                appList.Add(GetAppList(jarry.ElementAt(i).ToString()));
            }

            return appList;
        }

        /// <summary>
        /// 解析专辑
        /// </summary>
        /// <param name="albumJson"></param>
        /// <returns></returns>
        public static Album GetAlbum(string albumJson)
        {
            dynamic albumj = JsonConvert.DeserializeObject(albumJson);
            Album album = new Album();

            return album;
        }

        /// <summary>
        /// 解析专辑列表
        /// </summary>
        /// <param name="jarry"></param>
        /// <returns></returns>
        public static List<Album> GetAlbumL(JArray jarry)
        {
            List<Album> albumList = new List<Album>();
            for (int i = 0; i < jarry.Count; i++)
            {
                albumList.Add(GetAlbum(jarry.ElementAt(i).ToString()));
            }

            return albumList;
        }


        /// <summary>
        /// 解析艺术家
        /// </summary>
        /// <param name="artistJson"></param>
        /// <returns></returns>
        public static Artist GetArtist(string artistJson)
        {
            dynamic artistj = JsonConvert.DeserializeObject(artistJson);
            Artist artist = new Artist();

            return artist;
        }


        /// <summary>
        /// 解析艺术家列表
        /// </summary>
        /// <param name="jarry"></param>
        /// <returns></returns>
        public static List<Artist> GetArtistL(JArray jarry)
        {
            List<Artist> artistList = new List<Artist>();
            for (int i = 0; i < jarry.Count; i++)
            {
                artistList.Add(GetArtist(jarry.ElementAt(i).ToString()));
            }

            return artistList;
        }

    }
}