using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _2702295373_PSDQuiz.Models;
using _2702295373_PSDQuiz.Repositories;

namespace _2702295373_PSDQuiz.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RefreshGrid();
            }
        }

        protected void RefreshGrid()
        {
            List<Burger> burgers = BurgerRepositories.GetAllBurgers();

            if(burgers != null && burgers.Count > 0)
            {
                burgerGV.Visible = true;
                burgerGV.DataSource = burgers;
                burgerGV.DataBind();
                ErrorLbl.Text = " ";
            }
            else
            {
                burgerGV.Visible = false;
                ErrorLbl.Text = "No Burger Found!";
            }
        }

        protected void burgerGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = burgerGV.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[0].Text);
            BurgerRepositories.UpdateBurger(id);

            burgerGV.EditIndex = -1;
            RefreshGrid();
        }

        protected void burgerGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = burgerGV.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Text);
            BurgerRepositories.DeleteBurger(id);

            burgerGV.EditIndex = -1;
            RefreshGrid();
        }

        protected void goToInsertPageBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertPage.aspx");
        }
    }
}