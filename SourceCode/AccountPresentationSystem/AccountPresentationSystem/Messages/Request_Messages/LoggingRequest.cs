using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NDDDSample.Domain.Shared;

namespace AccountPresentationSystem.Messages.Request_Messages
{
    public class LoggingRequest
    {
        public string TransactionReference;

        public Enumeration.LoggingPriority LoggingPriority;

        public string Message;

        public DateTime TimeStamp;
    }
}