using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Web;
using AccountPresentationSystem.Messages.Request_Messages;
using AccountPresentationSystem.Domain.Shared;

namespace AccountPresentationSystem.Infrastructure
{
    public class ScrapeSessionQue
    {
        public MessageQueue MQ { get; set; }
        public ScrapeSession scrapeSession { get; set; }
        private Logging log = new Logging();


        public void ProcessStart(string refNum)
        {
            try
            {
                while (ReadQueueSize(refNum) > 0)
                {
                    if (MessageQueue.Exists(@".\Private$\ScrapeSessionsQueue"))
                    {
                        MQ = new System.Messaging.MessageQueue(@".\Private$\ScrapeSessionsQueue");
                        MQ.SetPermissions("Everyone", MessageQueueAccessRights.FullControl, AccessControlEntryType.Allow);

                        if (MQ != null)
                        {
                            Message processMessage = MQ.Receive(new TimeSpan(0, 0, 0, 0, 10));

                            processMessage.Formatter = new XmlMessageFormatter(new Type[] { typeof(ScrapeSession) });
                            ScrapeSession _scrapeSession = (ScrapeSession)processMessage.Body;

                            // Call the scraper
                        }
                    }
                    else
                    {
                        log.LogMessage(Enumeration.LoggingPriority.Low, refNum, "Create new Que");

                        MQ = MessageQueue.Create(@".\Private$\ScrapeSessionsQueue");
                        MQ.SetPermissions("Everyone", MessageQueueAccessRights.FullControl, AccessControlEntryType.Allow);
                    }
                }
            }
            catch (MessageQueueException mqEx)
            {
                log.LogMessage(Enumeration.LoggingPriority.High, refNum, mqEx);
            }
            catch (Exception ex)
            {
                log.LogMessage(Enumeration.LoggingPriority.High, refNum, ex);
            }
        }

        public void AddQProcess(string refNum)
        {
            try
            {
                if (MessageQueue.Exists(@".\Private$\ScrapeSessionsQueue"))
                {
                    MQ = new System.Messaging.MessageQueue(@".\Private$\ScrapeSessionsQueue");
                    MQ.SetPermissions("Everyone", MessageQueueAccessRights.FullControl, AccessControlEntryType.Allow);
                }
                else
                {
                    log.LogMessage(Enumeration.LoggingPriority.Low, refNum, "Creating MS message queue with name: " + @".\Private$\ScrapeSessionsQueue");

                    MQ = MessageQueue.Create(@".\Private$\ScrapeSessionsQueue");
                    MQ.SetPermissions("Everyone", MessageQueueAccessRights.FullControl, AccessControlEntryType.Allow);
                }

                ScrapeSession session = new ScrapeSession
                {
                    AccountPassword = scrapeSession.AccountPassword,
                    AccountUsername = scrapeSession.AccountUsername,
                    ReferenceNumber = refNum,
                    Rules = scrapeSession.Rules,
                    ScrapeURL = scrapeSession.ScrapeURL
                };

                MQ.Send(session);
            }
            catch (MessageQueueException mqEx)
            {
                log.LogMessage(Enumeration.LoggingPriority.High, refNum, mqEx);
            }
            catch (Exception ex)
            {
                log.LogMessage(Enumeration.LoggingPriority.High, refNum, ex);
            }
        }

        public int ReadQueueSize(string refNum)
        {
            try
            {
                if (MessageQueue.Exists(@".\Private$\ScrapeSessionsQueue"))
                {
                    MessageQueue mQ = new MessageQueue(@".\Private$\ScrapeSessionsQueue", false, true);

                    int messageCount = 0;

                    using (MessageEnumerator messageEnumerator = mQ.GetMessageEnumerator2())
                    {
                        while (messageEnumerator.MoveNext())
                        {
                            messageCount++;
                        }
                    }

                    return messageCount;
                }

                return 0;
            }
            catch (Exception ex)
            {
                log.LogMessage(Enumeration.LoggingPriority.High, refNum, ex);

                return 0;
            }
        }
    }
}