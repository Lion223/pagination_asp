using ASPDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPDemo.Controllers
{
    public class HomeController : Controller
    {
        private List<ProgrammingLanguage> programmingLanguages;

        public HomeController()
        {
            programmingLanguages = new List<ProgrammingLanguage>();

            programmingLanguages.Add(new ProgrammingLanguage { Id = 1, Name = "C#", Creator = "Anders Hejlsberg" });
            programmingLanguages.Add(new ProgrammingLanguage { Id = 2, Name = "Java", Creator = "James Gosling" });
            programmingLanguages.Add(new ProgrammingLanguage { Id = 3, Name = "C++", Creator = "Bjarne Stroustrup" });
            programmingLanguages.Add(new ProgrammingLanguage { Id = 4, Name = "Python", Creator = "Guido van Rossum" });
            programmingLanguages.Add(new ProgrammingLanguage { Id = 5, Name = "C", Creator = "Dennis Ritchie" });
            programmingLanguages.Add(new ProgrammingLanguage { Id = 6, Name = "JavaScript", Creator = "Brendan Eich" });
            programmingLanguages.Add(new ProgrammingLanguage { Id = 7, Name = "PHP", Creator = "Rasmus Lerdorf" });
            programmingLanguages.Add(new ProgrammingLanguage { Id = 8, Name = "SQL", Creator = "Donald D. Chamberlin" });
            programmingLanguages.Add(new ProgrammingLanguage { Id = 9, Name = "MATLAB", Creator = "Cleve Moler" });
            programmingLanguages.Add(new ProgrammingLanguage { Id = 10, Name = "asm", Creator = "Nathaniel Rochester" });
        }

        public ActionResult Index(int page = 1)
        {
            int pageSize = 3;
            IEnumerable<ProgrammingLanguage> pageContent = programmingLanguages.Skip((page - 1) * pageSize).Take(pageSize);
            PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = programmingLanguages.Count };
            IndexViewModel indexViewModel = new IndexViewModel { PageInfo = pageInfo, ProgrammingLanguages = pageContent };
            return View(indexViewModel);
        }
    }
}