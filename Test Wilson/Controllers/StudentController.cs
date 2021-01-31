using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Wilson.Models;

namespace Test_Wilson.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student s1 = new Student("Max", "Payne", "Management", "D", 22, 1);
            Student s2 = new Student("Tomb", "Raider", "Management", "B", 21, 2);
            Student s3 = new Student("Alan", "Wake", "Commerce", "A", 32, 3);
            Student s4 = new Student("Jessica", "Faden", "Scientology", "A", 12, 4);
            Student s5 = new Student("Mad", "Max", "CSIT", "B", 11, 5);

            List<Student> studentList = new List<Student> { s1, s2, s3, s4, s5 };
            return View(studentList);
        }
        public IActionResult Profile(int studentId)
        {
            StudentProfile s1 = new StudentProfile("Max Payne", 21, "Male", "1997/5/10", "USA", 1);
            StudentProfile s2 = new StudentProfile("Tomb Raider", 28, "Female", "1995/8/12", "India", 2);
            StudentProfile s3 = new StudentProfile("Alan Wake", 24, "Male", "1992/5/12", "China", 3);
            StudentProfile s4 = new StudentProfile("Jessica Faden", 30, "Female", "1987/5/11", "Afganistan", 4);
            StudentProfile s5 = new StudentProfile("Mad Max", 41, "Male", "1967/5/10", "Saudi", 5);
            List<StudentProfile> studentProfileList = new List<StudentProfile> { s1, s2, s3, s4, s5 };
            foreach(var studentProfile in studentProfileList)
            {
                if(studentProfile.Id == studentId)
                {
                    return View(studentProfile);
                }
            }
            return View(s1);
        }
    }
}
