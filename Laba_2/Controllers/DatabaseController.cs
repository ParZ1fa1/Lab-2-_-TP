using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Laba_2.Models;
using System.Web;
using System.Reflection;


namespace Laba_2.Controllers
{
    public class DatabaseController : Controller
    {
        // Список экземпляров Person
        private static List<Person> _personsList = new List<Person>();

        // Создание аккаунта
        // GET: /Database/Creat_Data
        [HttpGet]
        public ActionResult Creat_Data()
        {
            if (Session["user"] == null)
            {
                Session["user"] = 0;
            }
            else
            {
                Session["user"] = Int32.Parse(Convert.ToString(Session["user"])) + 1;
            }
            return View("Creat_Data");
        }

        // Просмотр созданного аккаунта 
        [HttpPost]
        public ActionResult View_Data(Person person)
        {
            person.PersonId = Int32.Parse(Convert.ToString(Session["user"]));
            _personsList.Add(person);
            return View("View_Data", person);
        }

        // Просмотр базы данных
        public ActionResult Data_Base()
        {
            // true - внешний метод, false - внутренний;
            TempData["method"] = false; 
            return View("Data_Base", _personsList);
        }
    }
}
