using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UniManagementSystem.Model;

namespace UniManagementSystem.DAL
{
    public class DepartmentGateway : CommonGateway
    {
        public List<Departments> GetAllDepartments()
        {
            Query = "Select * from Departments";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();

            Reader = Command.ExecuteReader();

            List<Departments> departments = new List<Departments>();
            while (Reader.Read())
            {
                Departments department = new Departments();
                department.ID = Convert.ToInt32(Reader["Id"]);
                department.Code = Reader["Code"].ToString();
                department.Name = Reader["Name"].ToString();

                departments.Add(department);
            }
            Reader.Close();
            Connection.Close();
            return departments;
        }

        public Departments IsExist(string Code)
        {
            Query = "Select * from Departments WHERE Code='" + Code + "'";

            Command = new SqlCommand(Query, Connection);
            Connection.Open();

            Reader = Command.ExecuteReader();

            Departments aDepartments = null;
            if (Reader.HasRows)
            {
                Reader.Read();
                aDepartments = new Departments();
                aDepartments.ID = Convert.ToInt16(Reader["id"]);
                aDepartments.Code = Reader["Code"].ToString();
                aDepartments.Name = Reader["Name"].ToString();
            }
            Reader.Close();
            Connection.Close();
            return aDepartments;
        }

        public int SaveDepartment(Departments aDepartment)
        {
            Query = "Insert Into Departments (Name,Code) Values('" + aDepartment.Name + "','" + aDepartment.Code+ "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }

}