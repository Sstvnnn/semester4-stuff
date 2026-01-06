using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalQuiz.Repositories;

namespace FinalQuiz.View
{
    public partial class InsertPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected bool IsAlpha(string name)
        {
            foreach(char c in name)
            {
                if(!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            string name = NameTb.Text;
            string price = PriceTb.Text;    

            // Validasi name and price
            if(string.IsNullOrEmpty(name) || name.Length < 3 || name.Length > 30 || !IsAlpha(name))
            {
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
                ErrorLbl.Text = "Name is Invalid!";
                return;
            } 

            if(string.IsNullOrEmpty(price) || int.Parse(price) <= 0)
            {
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
                ErrorLbl.Text = "Price is Invalid!";
                return;
            }

            ErrorLbl.ForeColor = System.Drawing.Color.Green;
            ErrorLbl.Text = "New Burger Successfully Added!";

            BurgerRepositories.InsertBurger(name, int.Parse(price));
            Response.Redirect("~/View/HomePage.aspx");
        }
    }
}