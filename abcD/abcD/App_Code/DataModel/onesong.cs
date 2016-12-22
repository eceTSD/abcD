using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace abcD.App_Code.DataModel
{
    public class onesong
    {
        private string _title;

        private string _artist;

        private string _mp3;

        private string _poster;

        public string title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public string artist
        {
            get
            {
                return _artist;
            }

            set
            {
                _artist = value;
            }
        }

        public string mp3
        {
            get
            {
                return _mp3;
            }

            set
            {
                _mp3 = value;
            }
        }

        public string poster
        {
            get
            {
                return _poster;
            }

            set
            {
                _poster = value;
            }
        }
    }
}