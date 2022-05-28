using System;
using System.Collections.Generic;
using UniManagementSystem.BLL;
using UniManagementSystem.Model;

namespace UniManagementSystem.UI
{
    public partial class StudentEntry : System.Web.UI.Page
    {
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

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Students aStudent = new Students();
            aStudent.Name = nameTextBox.Text;
            aStudent.RegNo = registrationNumberTextBox.Text;
            aStudent.DepartmentId = Convert.ToInt32(departmentDropDownList.SelectedValue);
            aStudent.Email = emailTextBox.Text;

            StudentsManager studentsManager = new StudentsManager();

            entryMessageLabelLabel.Text = studentsManager.SaveStudent(aStudent);
        }
    }
}