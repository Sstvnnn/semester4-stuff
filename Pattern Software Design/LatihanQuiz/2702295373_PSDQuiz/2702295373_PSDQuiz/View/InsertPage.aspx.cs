using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _2702295373_PSDQuiz.Repositories;

namespace _2702295373_PSDQuiz.View
{
    public partial class InsertPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected Boolean isAlpha(string name)
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

            if(string.IsNullOrEmpty(name) || name.Length < 3 || name.Length > 30 || !isAlpha(name))
            {
                ErrorLbl.Text = "Invalid name!";
                return;
            } 

            if(string.IsNullOrEmpty(price) || int.Parse(price) <= 0)
            {
                ErrorLbl.Text = "Invalid price!";
                return;
            }  
            ErrorLbl.Text = " ";
            BurgerRepositories.InsertBurger(name, int.Parse(price));
            Response.Redirect("~/View/HomePage.aspx");
        }
    }
}