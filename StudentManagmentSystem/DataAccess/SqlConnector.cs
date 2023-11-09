using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem
{
    public class SqlConnector : IDataConnection
    {
        public DepartmentModel CreateDepartment(DepartmentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("StudentDB")))
            {
                var p = new DynamicParameters();
                p.Add("@DpartName", model.DeptName);
                p.Add("@DpartDetails", model.DeptDetails);
                p.Add("@DpartID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spDepartment_Insert",p,commandType: CommandType.StoredProcedure);

                model.DeptId = p.Get<int>("@DpartID");

                return model;
            }
        }

        public List<DepartmentModel> GetAllDepartments()
        {
            List<DepartmentModel> ouput;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("StudentDB")))
            {
               ouput = connection.Query<DepartmentModel>("spDepartment_GetAll").ToList();
            }

            return ouput;
        }

        public StudentModel CreateStudent(StudentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("StudentDB")))
            {
                var p = new DynamicParameters();
                p.Add("@StudentName", model.StudentName);
                p.Add("@StudentPhone", model.StudentPhone);
                p.Add("@StudentAddress", model.StudentAddress);
                p.Add("@StudentGender", model.StudentGender);
                p.Add("@DepartID", model.DepartID);
                p.Add("@StudentID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spStudents_Insert", p, commandType: CommandType.StoredProcedure);

                model.StudentID = p.Get<int>("@StudentID");

                return model;
            }
        }

        public List<StudentModel> GetAllStudents()
        {
            List<StudentModel> ouput;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("StudentDB")))
            {
                ouput = connection.Query<StudentModel>("spStudent_GetAll").ToList();
            }

            return ouput;
        }


    }
}
