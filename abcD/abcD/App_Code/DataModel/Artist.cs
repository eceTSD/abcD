using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace abcD.App_Code.DataModel
{
    public class Artist: DataBase
    {
        private long id;

        private string name;

        private string picUrl;

        private int musicSize;

        private List<Album> hotAlbums;

        /// <summary>
        /// 作者id
        /// </summary>
        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        /// <summary>
        /// 作者名称
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }



        /// <summary>
        /// 作者图片
        /// </summary>
        public string PicUrl
        {
            get
            {
                return picUrl;
            }

            set
            {
                picUrl = value;
            }
        }


        /// <summary>
        /// 歌曲数量
        /// </summary>
        public int MusicSize
        {
            get
            {
                return musicSize;
            }

            set
            {
                musicSize = value;
            }
        }

        /// <summary>
        /// 热门专辑
        /// </summary>
        public List<Album> HotAlbums
        {
            get
            {
                return hotAlbums;
            }

            set
            {
                hotAlbums = value;
            }
        }
    }
}