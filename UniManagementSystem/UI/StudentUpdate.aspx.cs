using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniManagementSystem.BLL;
using UniManagementSystem.Model;

namespace UniManagementSystem.UI
{
    public partial class StudentUpdate : System.Web.UI.Page
    {
        StudentsManager aStudentsManager = new StudentsManager();
        DepartmentManager aDepartmentManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Departments> Departments = aDepartmentManager.GetAllDepartments();
                departmentDropDownList.DataSource = Departments;
                departmentDropDownList.DataTextField = "Code";
                departmentDropDownList.DataValueField = "Id";
                departmentDropDownList.DataBind();
            }
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string regNo = regNoTextBox.Text;

            Students aStudents = aStudentsManager.SearchStudent(regNo);

            if (aStudents == null)
            {
                nameTextBox.Text = String.Empty;
                emailTextBox.Text = String.Empty;
                //departmentTextBox.Text = String.Empty;

                messageLabel.Text = "No student in this registration numbre";
            }
            else
            {
                messageLabel.Text = String.Empty;
                idHiddenField.Value = aStudents.Id.ToString();
                nameTextBox.Text = aStudents.Name;
                emailTextBox.Text = aStudents.Email;
                //departmentTextBox.Text = aStudents.Department;
                departmentDropDownList.Text = aStudents.DepartmentId.ToString();
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Students aStudents = new Students();
            aStudents.Id = Convert.ToInt32(idHiddenField.Value);
            aStudents.Name = nameTextBox.Text;
            aStudents.Email = emailTextBox.Text;
           // aStudents.Department = departmentTextBox.Text;
            aStudents.DepartmentId = Convert.ToInt32(departmentDropDownList.SelectedValue);

            string message = aStudentsManager.Update(aStudents);

            messageLabel.Text = message;
        }
    }
}