using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using entityLayer;
using dataAccessLayer;
using BusinessLogicLayer;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace okul_kayit_bootstrap
{
    public partial class ogrenciEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            entityOgrenci ent = new entityOgrenci();

            try
            {
                ent.AD = txtAd.Text;
                ent.SOYAD = txtSoyad.Text;
                ent.NUMARA = Convert.ToInt32(txtNumara.Text);
                ent.SINIF = DropDownList1.SelectedValue.ToString();
                ent.DERS = DropDownList2.SelectedValue.ToString();
            }
            catch (Exception)
            {
                message.Text = "Lütfen verileri doğru giriniz.";
                message.BackColor = System.Drawing.Color.Red;
                message.Visible = true;
                return;
            }

            





            int dersID = int.Parse(DropDownList2.SelectedValue.ToString());

            entityDers mevcut = DALders.kontenjanSorgu(dersID);    

            if(mevcut != null)
            {
                if(mevcut.MEVCUT < mevcut.MAX)
                {
                    BLLogrenci.BLLogrenciEkle(ent);
                    BLLders.BLLKontenjanGuncelle(dersID);
                    message.Text = "Öğrenci başarıyla eklendi.";
                    message.BackColor = System.Drawing.Color.Green;
                    message.Visible = true;
                }
                else
                {
                    message.Text = "Dersin kontenjanı dolu.";
                    message.BackColor = System.Drawing.Color.Red;
                    message.Visible = true;
                }

            }



        }
    }
}