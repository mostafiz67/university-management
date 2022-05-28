using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniManagementSystem.BLL;

namespace UniManagementSystem.UI
{
    public partial class ShowAllStudents : System.Web.UI.Page
    {
        StudentsManager studentsManager = new StudentsManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            allStudentsGridView.DataSource = studentsManager.GetAllStudents();
            allStudentsGridView.DataBind();
        }

        protected void DeleteLinkButton_Click(object sender, EventArgs e)
        {
       
            LinkButton deleteButton = sender as LinkButton;
            DataControlFieldCell selectedCell = deleteButton.Parent as DataControlFieldCell;
            GridViewRow selecedRow = selectedCell.Parent as GridViewRow;
            HiddenField selectedHiddenField = selecedRow.FindControl("idHiddenField") as HiddenField;
            int id = Convert.ToInt32(selectedHiddenField.Value);

            string message = studentsManager.Delete(id);
            Response.Write(message);
        }

        protected void UpdateLinkButton_Click(object sender, EventArgs e)
        {

            LinkButton updateButton = sender as LinkButton;
            DataControlFieldCell selectedCell = updateButton.Parent as DataControlFieldCell;
            GridViewRow selecedRow = selectedCell.Parent as GridViewRow;
            HiddenField selectedHiddenField = selecedRow.FindControl("idHiddenField") as HiddenField;
            int id = Convert.ToInt32(selectedHiddenField.Value);

            //string message = studentsManager.Delete(id);
            Response.Redirect("UpdateUI.aspx?id="+id);
        }

    }
}