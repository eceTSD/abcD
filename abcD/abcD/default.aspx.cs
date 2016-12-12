using abcD.App_Code.MusicApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace abcD
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string abcD;
        protected void Page_Load(object sender, EventArgs e)
        {
            MusicApis ma = new MusicApis();
            abcD =   ma.Get_Music();
        }
    }
}