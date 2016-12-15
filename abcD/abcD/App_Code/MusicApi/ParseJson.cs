using abcD.App_Code.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace abcD.App_Code.MusicApi
{
    public abstract class ParseJson
    {

        public static List<Song> ParseSongList(string SongList)
        {
            List<Song> SongL = new List<Song>();
            
            return SongL;
        }

        public static Song ParseSong(string Song)
        {
            Song song = new Song();
            return song;
        }
    }
}