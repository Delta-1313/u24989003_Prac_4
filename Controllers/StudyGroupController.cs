using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace u2498903_Prac_4.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult ListPeople()
        {
            List<Models.StudyGroupModel> people = new List<Models.StudyGroupModel>();

            people.Add(new Models.StudyGroupModel { StudentNum = "u24989003", FirstName = "Cassavin", LastName = "Bluemeyer", Email = "u24989003@tuks.co.za", myLink = "~/HTML/Cassavin.html" });
            people.Add(new Models.StudyGroupModel { StudentNum = "u24987906", FirstName = "Mohale", LastName = "Ntsasa", Email = "u24987906@tuks.co.za", myLink = "~/HTML/Mohale.html" });
            people.Add(new Models.StudyGroupModel { StudentNum = "u24636933", FirstName = "Wahkeni", LastName = "Frans", Email = "u24636933@tuks.co.za", myLink = "~/HTML/Wahkeni.html" });
            people.Add(new Models.StudyGroupModel { StudentNum = "u24755100", FirstName = "Kea", LastName = "Mathube", Email = "u24755100@tuks.co.za", myLink = "~/HTML/Kea.html" });
            people.Add(new Models.StudyGroupModel { StudentNum = "u24698190", FirstName = "Lwandile", LastName = "Khoza", Email = "u24698190@tuks.co.za", myLink = "~/HTML/Lwandile.html" });

            return View(people);
        }
    }
}