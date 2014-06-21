using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using AccountPresentationSystem.Messages.Request_Messages;
using NDDDSample.Domain.Shared;

namespace AccountPresentationSystem.Infrastructure
{
    public class Logging
    {
        public bool LogMessage(Enumeration.LoggingPriority priority, string transactionReference, string message)
        {
            try
            {
                LoggingRequest lsmr = new LoggingRequest
                {
                    TransactionReference = transactionReference,
                    LoggingPriority = priority,
                    Message = "Message: " + message,
                    TimeStamp = DateTime.Now
                };

                //Call the Repo and insert the data (LoggingServiceRequest)

                return true;
            }
            catch
            {
                // do nothing

                return false;
            }
        }

        public bool LogMessage(Enumeration.LoggingPriority priority, string transactionReference, Exception exception)
        {
            try
            {
                StringBuilder s = new StringBuilder();
                s.AppendFormat("Exception: {0} |", String.IsNullOrEmpty(exception.Message) ? "NONE" : exception.Message);
                if (exception.InnerException != null)
                {
                    s.AppendFormat("Inner Exception Message: {0} |", String.IsNullOrEmpty(exception.InnerException.Message) ? "NONE" : exception.InnerException.Message);
                    s.AppendFormat("Inner Exception Source: {0} |", String.IsNullOrEmpty(exception.InnerException.Source) ? "NONE" : exception.InnerException.Source);
                }
                s.AppendFormat("Exception Source: {0} |", String.IsNullOrEmpty(exception.Source) ? "NONE" : exception.Source);
                s.AppendFormat("Exception Stack Trace: {0} ", String.IsNullOrEmpty(exception.StackTrace) ? "NONE" : exception.StackTrace);

                LoggingRequest lsmr = new LoggingRequest
                {
                    TransactionReference = transactionReference,
                    LoggingPriority = priority,
                    Message = s.ToString(),
                    TimeStamp = DateTime.Now
                };

                //Call the Repo and insert the data (LoggingServiceRequest)

                return true;
            }
            catch
            {
                // do nothing

                return false;
            }
        }

        public bool LogMessage(Enumeration.LoggingPriority priority, string transactionReference, object messageObject)
        {
            try
            {
                LoggingRequest lsmr = new LoggingRequest
                {
                    TransactionReference = transactionReference,
                    LoggingPriority = priority,
                    Message = new MessageObjectWrapper(messageObject).ToString(),
                    TimeStamp = DateTime.Now
                };

                //Call the Repo and insert the data (LoggingServiceRequest)

                return true;
            }
            catch
            {
                // do nothing

                return false;
            }
        }
    }
}