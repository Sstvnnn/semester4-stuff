using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LatihanQuizTerakhir.Models;
using LatihanQuizTerakhir.Repositories;

namespace LatihanQuizTerakhir.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        // Di homepage ada 5 method -> tambahan nya itu refreshGrid semua make protected void
        protected void Page_Load(object sender, EventArgs e)
        {
            // jangan lupa postback


        }

        protected void refreshGrid()
        {
            List<Burger> burgers = BurgerRepositories.getAllBurger();

            // ada validasi isi list != null sama isi nya > 0
            if(burgers != null && burgers.Count > 0)
            {
                burgerGV.Visible = true;
                burgerGV.DataSource = burgers;
                burgerGV.DataBind();
                ErrorLbl.Text = string.Empty;
            }
            else
            {
                burgerGV.Visible = false;
                ErrorLbl.Text = "No Burgers Found!";
            }

        }


        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertPage.aspx");
        }

        protected void burgerGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // Disini pake Rows e.newEditIndex 
            GridViewRow row = burgerGV.Rows[e.NewEditIndex];

            // Disini pake parse row Cells[0] text
            int ramenId = int.Parse(row.Cells[0].Text);

            BurgerRepositories.UpdateStatus(ramenId);

            // matiin fungsi edit lgsg dari gv
            burgerGV.EditIndex = -1;
            refreshGrid();
        }

        protected void burgerGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // Disini pake Rows e.RowIndex
            GridViewRow row = burgerGV.Rows[e.RowIndex];
            int ramenId = int.Parse(row.Cells[0].Text);

            BurgerRepositories.deleteBurger(ramenId);

            burgerGV.EditIndex = -1;
            refreshGrid();
        }
    }
}