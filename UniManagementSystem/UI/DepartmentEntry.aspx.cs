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
    public partial class DepartmentEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Departments aDepartment = new Departments();
            aDepartment.Code = departmentCodeTextBox.Text;
            aDepartment.Name = departmentNameTextBox.Text;

            DepartmentManager aDepartmentManager = new DepartmentManager();

            departmentMessageLabel.Text = aDepartmentManager.SaveDepartment(aDepartment);
        }
    }
}