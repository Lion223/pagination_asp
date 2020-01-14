using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPDemo.Models
{
    public class ProgrammingLanguage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Creator { get; set; }
    }
}