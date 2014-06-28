using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    public class LoadManagerErrors
    {
        public int ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public string Message { get; set; }
    }
}
