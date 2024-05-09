using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class StudentController: Controller
{
    // public ActionResult<string> Index()
    // {
    //     return "I am from Student Index";
    // }
    public ActionResult Index()
    {
        //object initializer syntax
        Person stu1 = new Person(){Firstname = "Asmita",Lastname = "OJha",Address = "Kanchanpur",Grade= 12,Gender = 'F'};
        Person stu2 = new Person(){Firstname = "Asmita",Lastname = "OJha",Address = "Kanchanpur",Grade= 12,Gender = 'F' };
        Person stu3 = new Person(){Firstname = "Asmita",Lastname = "OJha",Address = "Kanchanpur",Grade= 12,Gender = 'F'};
        Person stu4 = new Person(){Firstname = "Asmita",Lastname = "OJha",Address = "Kanchanpur",Grade= 12,Gender = 'F'};
        Person stu5 = new Person(){Firstname = "Asmita",Lastname = "OJha",Address = "Kanchanpur",Grade= 12,Gender = 'F'};

        List<Person> students = new List<Person>(){stu1,stu2,stu3,stu4,stu5};
        return View(students);
    } 

}
