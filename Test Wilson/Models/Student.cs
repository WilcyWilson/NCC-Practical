using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Wilson.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Faculty { get; set; }
        public string Section { get; set; }
        public int RollNo { get; set; }
        public int Id { get; set; }

        public Student(string firstName, string lastName, string faculty, string section, int rollNo,int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Faculty = faculty;
            this.Section = section;
            this.RollNo = rollNo;
            this.Id = id;
        }

    }

}
