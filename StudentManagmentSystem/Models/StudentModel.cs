using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem
{
    public class StudentModel
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentPhone { get; set; }
        public string StudentAddress { get; set;}
        public string StudentGender { get; set;}
        public int DepartID { get; set;}

        public StudentModel( int studentID, string studentName, string studentPhone, string studentAddress,string studentGender , int departID)
        {
            StudentID = studentID;
            StudentName = studentName;
            StudentPhone = studentPhone;
            StudentAddress = studentAddress;
            StudentGender = studentGender;
            DepartID = departID;
        }

        public StudentModel(string studentName, string studentPhone, string studentAddress, string studentGender, int departID)
        {
            StudentName = studentName;
            StudentPhone = studentPhone;
            StudentAddress = studentAddress;
            StudentGender = studentGender;
            DepartID = departID;
        }

    }

   
}
