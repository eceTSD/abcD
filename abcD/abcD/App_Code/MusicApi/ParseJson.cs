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
        public static Song GetSong(string songJson)
        {

            dynamic user = JsonConvert.DeserializeObject(songJson);
            Song song = new Song();
            return song;
        }

        public static List<Song> GetSongL(JArray jarry)
        {            
            List<Song> SongList = new List<Song>();
            for(int i = 0; i < jarry.Count; i++)
            {
                SongList.Add(GetSong(jarry.ElementAt(i).ToString())); 
            }
           
            return SongList;
        }
    }
}