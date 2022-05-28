using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniManagementSystem.Model.ViewModel
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string RegNo { get; set; }
        public string StudentName { get; set; }
        public string DepartmentName { get; set; }
        public string Email { get; set; }
    }
}