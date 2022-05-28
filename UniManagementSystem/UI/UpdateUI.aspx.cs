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
    public partial class UpdateUI : System.Web.UI.Page
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

                int id = Convert.ToInt32(Request.QueryString["id"]);
                Students aStudents = aStudentsManager.GetStudentByID(id);

                if (aStudents != null)
                {
                    LoadFormWithStudent(aStudents);
                }
            }
            
        }

        private void LoadFormWithStudent(Students aStudents)
        {
            idHiddenField.Value = aStudents.Id.ToString();
            regNoTextBox.Text = aStudents.RegNo;
            nameTextBox.Text = aStudents.Name;
           // departmentTextBox.Text = aStudents.Department;
            departmentDropDownList.Text = aStudents.DepartmentId.ToString();
            emailTextBox.Text = aStudents.Email;
            departmentDropDownList.Text = aStudents.DepartmentId.ToString();
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Students aStudents = new Students();
            if (idHiddenField!=null)
            {
                aStudents.Id = Convert.ToInt32(idHiddenField.Value);
            }
           
            aStudents.Name = nameTextBox.Text;
            aStudents.Email = emailTextBox.Text;
            //aStudents.Department = departmentTextBox.Text;
            aStudents.DepartmentId = Convert.ToInt16(departmentDropDownList.SelectedValue);

            string message = aStudentsManager.Update(aStudents);

            messageLabel.Text = message;
        }
    }
}