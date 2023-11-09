using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem
{
    public interface IDataConnection
    {
        DepartmentModel CreateDepartment(DepartmentModel department);

        StudentModel CreateStudent(StudentModel student); 
        List<DepartmentModel> GetAllDepartments();
        List<StudentModel> GetAllStudents();
    }
}
