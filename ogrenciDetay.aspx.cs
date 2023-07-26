using BusinessLogicLayer;
using entityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace okul_kayit_bootstrap
{
    public partial class ogrenciDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ogrid"].ToString());

            txtID.Text = x.ToString();
            txtID.Enabled = false;

            


            if (Page.IsPostBack == false)
            {
                DropDownList1.DataSource = BLLsinif.sinifListele();
                DropDownList1.DataTextField = "SINIF";
                DropDownList1.DataValueField = "SINIFID";
                DropDownList1.DataBind();

                DropDownList2.DataSource = BLLders.dersListele();
                DropDownList2.DataTextField = "DERSAD";
                DropDownList2.DataValueField = "ID";
                DropDownList2.DataBind();



                List<entityOgrenci> liste = BLLogrenci.BLLdetay(x);
                txtAd.Text = liste[0].AD.ToString();
                txtSoyad.Text = liste[0].SOYAD.ToString();
                txtNumara.Text = liste[0].NUMARA.ToString();
                txtMevcutSinif.Text = liste[0].SINIF.ToString();
               txtMevcutDers.Text = liste[0].DERS.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            entityOgrenci ent = new entityOgrenci();

           
            ent.AD = txtAd.Text;
            ent.SOYAD = txtSoyad.Text;
            ent.NUMARA = Convert.ToInt32(txtNumara.Text);
            ent.SINIF = DropDownList1.SelectedValue.ToString();
            ent.DERS = DropDownList2.SelectedValue.ToString();
            ent.ID = Convert.ToInt32(txtID.Text);
            BLLogrenci.BLLogrenciGuncelle(ent);
            Response.Redirect("OgrenciListesi.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("ogrenciListesi.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ogrid"].ToString());
            entityOgrenci ent = new entityOgrenci();
            ent.ID = x;
            BLLogrenci.BLLogrenciSil(ent.ID);
            Response.Redirect("ogrenciListesi.aspx");
        }
    }
}