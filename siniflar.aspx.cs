using BusinessLogicLayer;
using entityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace okul_kayit_bootstrap
{
    public partial class siniflar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<entitySinif> sinifListe = BLLsinif.sinifListele();
            Repeater1.DataSource = sinifListe;
            Repeater1.DataBind();
        }
    }
}