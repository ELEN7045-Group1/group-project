using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Messages.Request_Messages
{
    public class ScrapeSession
    {
        public string ReferenceNumber { get; set; }
        public string ScrapeURL { get; set; }
        public string AccountUsername { get; set; }
        public string AccountPassword { get; set; }
        public List<string> Rules { get; set; }
    }
}