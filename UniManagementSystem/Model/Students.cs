using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniManagementSystem.Model
{
    public class Students
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }

        public int DepartmentId { get; set; }
        public string Email { get; set; }

        public Students(string name, string email, string regNo,int departmentId)
        {
            Name = name;
            RegNo = regNo;
            Email = email;
            DepartmentId = departmentId;
        }

        public Students()
        {

        }
    }
}
