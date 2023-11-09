using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentManagmentSystem
{
    public class DepartmentModel
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptDetails { get; set; }

        public DepartmentModel(int DepartID, string DpartName, string DpartDetails) {
            DeptId = DepartID;    
            DeptName = DpartName;
            DeptDetails = DpartDetails;
        }

        public DepartmentModel(string deptName, string deptDetails)
        {
            DeptName = deptName;
            DeptDetails = deptDetails;

        }
    }
}
