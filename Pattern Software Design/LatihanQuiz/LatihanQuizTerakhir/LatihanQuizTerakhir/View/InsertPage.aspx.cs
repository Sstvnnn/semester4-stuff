using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LatihanQuizTerakhir.Factory;
using LatihanQuizTerakhir.Models;
using LatihanQuizTerakhir.Repositories;

namespace LatihanQuizTerakhir.View
{
    public partial class InsertPage : System.Web.UI.Page
    {
        // Disini cuma kerjain di method insertnya
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected bool IsValidName(string name)
        {
            foreach(char c in name)
            {
                // inget allow space juga
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            // Validasi disini semua
            string name = NameTb.Text;
            string price = PriceTb.Text;

            // Validasi Nama harus diisi, 3-30 Character dan jg harus alphabet

            // 1. Validasi Error
            if(string.IsNullOrEmpty(name) || name.Length < 3 || name.Length > 30 || !IsValidName(name))
            {
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
                ErrorLbl.Text = "Burger name is invalid";
                return;
            }

            // Validasi Harga harus diisi, <= 0
            // Validasi Error
            if(string.IsNullOrEmpty(price) || int.Parse(price) <= 0)
            {
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
                ErrorLbl.Text = "Burger price is invalid";
                return;
            }

            BurgerRepositories.InsertBurger(name, int.Parse(price));

            ErrorLbl.ForeColor = System.Drawing.Color.Green;
            ErrorLbl.Text = "New Burger Successfully Inserted!";

            Response.Redirect("~/View/HomePage.aspx");

        }
    }
}