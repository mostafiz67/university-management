using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniManagementSystem.DAL;
using UniManagementSystem.Model;
using UniManagementSystem.Model.ViewModel;

namespace UniManagementSystem.BLL
{
    public class StudentsManager
    {
        StudentsGateway studentsGateway = new StudentsGateway();
        public string SaveStudent(Students aStudent)
        {
            if (aStudent.RegNo.Length >= 3)
            {
                Students student = studentsGateway.IsExist(aStudent.RegNo);
                if (student == null)
                {
                    int rowAffected = studentsGateway.SaveStudent(aStudent);
                    if (rowAffected > 0)
                    {
                        return "Successfully Inserted";
                    }
                    else
                    {
                        return "Failed";
                    }
                }
                else
                {
                    return "Registrtion number must be uniq";
                }
            }
            else
            {
                return "Reg no must be 3 digit long";
            }
        }

        public List<StudentViewModel> GetAllStudents()
        {
            return studentsGateway.GetAllStudent();
        }

        public Students SearchStudent(string regNo)
        {
            return studentsGateway.IsExist(regNo);


        }

        public string Update(Students aStudents)
        {
            int rowAffected = studentsGateway.Update(aStudents);

            if (rowAffected>0)
            {
                return "Update Sucessfully";
            }
            else
            {
                return "Update Failed";
            }
        }

        public string Delete(int id)
        {
            int rowAffected = studentsGateway.Delete(id);
            if (rowAffected > 0)
            {
                return "Delete Succeffully";
            }
            else
            {
                return "Delete Failed";
            }
        }

        public Students GetStudentByID(int id)
        {
            return studentsGateway.GetStudentsByID(id);
        }
    }
}
