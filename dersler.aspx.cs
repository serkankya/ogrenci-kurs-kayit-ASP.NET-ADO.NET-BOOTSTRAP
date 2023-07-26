using BusinessLogicLayer;
using dataAccessLayer;
using entityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace okul_kayit_bootstrap
{
    public partial class dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            if(Page.IsPostBack == false)
            {
                List<entityDers> dersListe = BLLders.dersListele();
                Repeater1.DataSource = dersListe;
                Repeater1.DataBind();
                
                
            }
        }

        
    }
}