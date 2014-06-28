using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    public class ScrapeData
    {
         public DateTime ScrapeDateTime { get; set; }
         public string ReferenceNumber { get; set; }
         public string ScrapeURL { get; set; }
         public string AccountUsername { get; set; }
         public string AccountPassword { get; set; }
         public List<string> Rules { get; set; }
    }
}