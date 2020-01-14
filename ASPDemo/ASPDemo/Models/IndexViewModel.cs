using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDemo.Models
{
    public class IndexViewModel
    {
        public IEnumerable<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}