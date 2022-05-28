using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UniManagementSystem.Model;
using UniManagementSystem.Model.ViewModel;

namespace UniManagementSystem.DAL
{
    public class StudentsGateway:CommonGateway
    {
        //private string connectionString = WebConfigurationManager.ConnectionStrings["UniversityMgtSystem"].ConnectionString;

        
        public int SaveStudent(Students aStudent)
        {
            //1.Connect Database

            //SqlConnection connection = new SqlConnection(connectionString);

            //2.Write the query

            Query = "Insert Into Students (Name,RegNo,Email,DepartmentId) Values('"+ aStudent.Name + "','" + aStudent.RegNo + "','"+aStudent.Email+"','"+aStudent.DepartmentId+"')";

            //3. Execute the query using connection

            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;


        }

        public List<StudentViewModel> GetAllStudent()
        {
           // Connection = new SqlConnection(connectionString);

            Query = "Select * from StudentWiseDepartment";

            Command = new SqlCommand(Query, Connection);
            Connection.Open();

            Reader = Command.ExecuteReader();
            List<StudentViewModel> student = new List<StudentViewModel>();

            while (Reader.Read())
            {
                StudentViewModel students = new StudentViewModel();
                students.StudentId = Convert.ToInt32(Reader["StudentsId"]);
                students.StudentName = Reader["StudentsName"].ToString();
                students.Email = Reader["Email"].ToString();
                students.DepartmentName = Reader["DepartmentName"].ToString();
                students.RegNo = Reader["RegNo"].ToString();

                student.Add(students);
            }
            Reader.Close();
            Connection.Close();

            return student;
        }

        public Students IsExist(string regNo)
        {

           // Connection = new SqlConnection(connectionString);

            Query = "Select * from Students WHERE RegNo='" + regNo + "'";

            Command = new SqlCommand(Query, Connection);
            Connection.Open();

            Reader = Command.ExecuteReader();

            Students aStudent = null;
            if (Reader.HasRows)
            {
                Reader.Read();
                aStudent = new Students();
                aStudent.Id = Convert.ToInt32(Reader["id"]);
                aStudent.Name = Reader["Name"].ToString();
                aStudent.RegNo = Reader["RegNo"].ToString();
                aStudent.DepartmentId = Convert.ToInt32(Reader["DepartmentId"]);
                aStudent.Email = Reader["Email"].ToString();
            }
            Reader.Close();
            Connection.Close();
            return aStudent;
        }

        public int Update(Students aStudents)
        {
            Query = "Update Students Set Name='"+aStudents.Name+"',Email='"+aStudents.Email+"',DepartmentId='"+aStudents.DepartmentId+"' Where id="+aStudents.Id;
            Command = new SqlCommand(Query,Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public int Delete(int id)
        {
            Query = "Delete from Students Where id=" + id;
            Command = new SqlCommand(Query,Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public Students GetStudentsByID(int id)
        {
            Query = "Select * from Students Where id=" + id;
            Command = new SqlCommand(Query, Connection);
            Connection.Open();

            Reader = Command.ExecuteReader();

            Students aStudent = null;
            if (Reader.HasRows)
            {
                Reader.Read();
                aStudent = new Students();
                aStudent.Id = Convert.ToInt32(Reader["id"]);
                aStudent.Name = Reader["Name"].ToString();
                aStudent.RegNo = Reader["RegNo"].ToString();
                aStudent.DepartmentId = Convert.ToInt32(Reader["DepartmentId"]);
                aStudent.Email = Reader["Email"].ToString();
            }
            Reader.Close();
            Connection.Close();
            return aStudent;
        }
    }
}