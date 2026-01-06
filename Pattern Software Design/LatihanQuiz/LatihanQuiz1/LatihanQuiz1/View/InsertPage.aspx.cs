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
    public partial class InsertPage : System.Web.UI.Page
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
            }
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            string name = NameTb.Text;
            int price = int.TryParse(PriceTb.Text, out price) ? price : -1;
            int type = int.Parse(TypeDdl.SelectedValue);

            if(name.Length == 0)
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
                // Insert ke DB
                //MsRaman ramen = new MsRaman();
                //ramen.RamenName = name;
                //ramen.RamenPrice = price;
                //ramen.RamenTypeID = type;

                //db.MsRamen.Add(ramen);
                //db.SaveChanges();
                RamenRepositories.insertRamen(name,price,type);

                Response.Redirect("~/View/Homepage.aspx");
            }
        }
    }
}