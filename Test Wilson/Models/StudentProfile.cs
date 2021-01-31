using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Wilson.Models
{
    public class StudentProfile
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }

        public StudentProfile(string name, int age, string sex, string dob, string address, int id)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.DOB = dob;
            this.Address = address;
            this.Id = id;
        }
    }
}
