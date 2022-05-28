using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniManagementSystem.DAL;
using UniManagementSystem.Model;

namespace UniManagementSystem.BLL
{
    
    public class DepartmentManager
    {
        DepartmentGateway aDepartmentGateway = new DepartmentGateway();

        public List<Departments> GetAllDepartments()
        {
            return aDepartmentGateway.GetAllDepartments();
        }

        public string SaveDepartment(Departments aDepartment)
        {
            Departments Department = aDepartmentGateway.IsExist(aDepartment.Code);
            if (Department==null)
            {
                int rowAffeced = aDepartmentGateway.SaveDepartment(aDepartment);
                if (rowAffeced>0)
                {
                    return "Successuffly Saved";
                }
                else
                {
                    return "Failed";
                }
            }
            else
            {
                return "Department Code must be Uniq";
            }
        }
    }
}