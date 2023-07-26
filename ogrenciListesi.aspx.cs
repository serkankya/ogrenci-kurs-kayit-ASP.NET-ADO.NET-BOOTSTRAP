using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using entityLayer;
using dataAccessLayer;
using BusinessLogicLayer;

namespace okul_kayit_bootstrap
{
    public partial class ogrenciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

                List<entityOgrenci> ogrListe = BLLogrenci.BLLlistele();

                Repeater1.DataSource = ogrListe;
                Repeater1.DataBind();
               

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}