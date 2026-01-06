using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LatihanQuiz1.Models;
using LatihanQuiz1.Repository;
using LatihanQuiz1.Singleton;

namespace LatihanQuiz1.View
{
    public partial class Homepage : System.Web.UI.Page
    {
        // Define DB
        //Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Nanti belajar kenapa pake LINQ dan ORM

            // Fetch db from data (LINQ)
            //List<MsRaman> ramens = (from ramen in db.MsRamen select ramen).ToList();

            // ORM (Entity Framework) -> nanti dipindahin ke function
            //List<MsRaman> ramens = db.MsRamen.ToList();

            //gvRamen.DataSource = ramens;
            //gvRamen.DataBind();
            if (!IsPostBack)
            {
                refreshData();
            }
            
        }

        protected void goToInsertPageBtn_Click(object sender, EventArgs e)
        {
            // Redirect to insert page
            Response.Redirect("~/View/InsertPage.aspx");
        }

        protected void gvRamen_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvRamen.Rows[e.RowIndex];
            int ramenId = int.Parse(row.Cells[0].Text);

            //MsRaman selectedRamen = db.MsRamen.Find(ramenId);
            //db.MsRamen.Remove(selectedRamen);
            //db.SaveChanges();
            RamenRepositories.deleteRamen(ramenId);

            refreshData();
        }

        protected void gvRamen_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // Ambil Row yg mau diedit
            GridViewRow row = gvRamen.Rows[e.NewEditIndex];
            int ramenId = int.Parse(row.Cells[0].Text);
            Response.Redirect("~/View/UpdatePage.aspx?id=" + ramenId);
        }

        protected void refreshData()
        {
            //List<MsRaman> ramens = db.MsRamen.ToList();
            List<MsRaman> ramens = RamenRepositories.getAllRamen();
            gvRamen.DataSource = ramens;
            gvRamen.DataBind();
        }
    }
}