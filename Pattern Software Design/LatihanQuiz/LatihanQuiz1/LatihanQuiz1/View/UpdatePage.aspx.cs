using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LatihanQuiz1.Models;
using LatihanQuiz1.Repository;

namespace LatihanQuiz1.View
{
    public partial class UpdatePage : System.Web.UI.Page
    {
        //Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //List<MsRamenType> ramenTypes = db.MsRamenTypes.ToList();
                List<MsRamenType> ramenTypes = RamenTypeRepositories.getAllTypes();
                TypeDdl.DataSource = ramenTypes;
                TypeDdl.DataBind();
                TypeDdl.DataValueField = "RamenTypeID";
                TypeDdl.DataTextField = "RamenTypeName";

                // Ambil data ramen yg dipilih dari ID yg dipassing di URL
                int ramenId = int.Parse(Request.QueryString["id"]);
                //MsRaman selectedRamen = db.MsRamen.Find(ramenId);
                MsRaman selectedRamen = RamenRepositories.getRamen(ramenId);
                NameLbl.Attributes["placeholder"] = selectedRamen.RamenName;
                PriceLbl.Attributes["placeholder"] = selectedRamen.RamenPrice.ToString();
                TypeDdl.SelectedValue = selectedRamen.MsRamenType.RamenTypeName;
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            string name = NameTb.Text;
            int price = int.TryParse(PriceTb.Text, out price) ? price : -1;
            int type = int.Parse(TypeDdl.SelectedValue);

            if (name.Length == 0)
            {
                ErrorLbl.Text = "Ramen name must be filled!";
                return;
            }
            else if (price == -1)
            {
                ErrorLbl.Text = "Ramen price must be integer!";
                return;
            }
            else
            {
                ErrorLbl.Text = " ";
                // Update DB
                int ramenId = int.Parse(Request.QueryString["id"]);
                //MsRaman ramen = db.MsRamen.Find(ramenId);
                //ramen.RamenName = name;
                //ramen.RamenPrice = price;
                //ramen.RamenTypeID = type;
                //db.SaveChanges();
                RamenRepositories.updateRamen(ramenId, name, price, type);

                Response.Redirect("~/View/Homepage.aspx");
            }
        }
    }
}