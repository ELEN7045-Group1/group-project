using AccountPresentationSystem.Domain.Model.APSUser;
using AccountPresentationSystem.Domain.Model.Billing;
using AccountPresentationSystem.Domain.Model.StatementHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebFrontend.App_Start
{
    public static class FakeData
    {
        public static List<Statement> Statements = new List<Statement>();
        public static List<APSUser> Users = new List<APSUser>();
        public static List<BillingCompany> BillingCompanies = new List<BillingCompany>();
        public static List<BillingAccount> BillingAccounts = new List<BillingAccount>();

        public static void InitFakeData()
        {
            ClearData();

            Users.Add(new APSUser(new APSUserId("1"), "paul", "Password1"));
            Users.Add(new APSUser(new APSUserId("2"), "koos", "Password2"));
            UserID = "1";

            BillingCompanies.Add(new BillingCompany(new BillingCompanyId("1"), "Ekhuruleni Municipality"));
            BillingCompanies.Add(new BillingCompany(new BillingCompanyId("2"), "Edgars"));
            BillingCompanies.Add(new BillingCompany(new BillingCompanyId("3"), "Virgin Money Credit Card"));

            BillingAccounts.Add(new BillingAccount(new BillingAccountId("1"), BillingCompanies.Find(x => x.billingCompanyId.IdString == "1").billingCompanyId, "pvc", "password1", Users.Find(x => x.APSUserId.IdString == "1")));
            BillingAccounts.Add(new BillingAccount(new BillingAccountId("2"), BillingCompanies.Find(x => x.billingCompanyId.IdString == "2").billingCompanyId, "pvc", "password1", Users.Find(x => x.APSUserId.IdString == "1")));
            BillingAccounts.Add(new BillingAccount(new BillingAccountId("3"), BillingCompanies.Find(x => x.billingCompanyId.IdString == "3").billingCompanyId, "pvc", "password1", Users.Find(x => x.APSUserId.IdString == "1")));
            BillingAccounts.Add(new BillingAccount(new BillingAccountId("4"), BillingCompanies.Find(x => x.billingCompanyId.IdString == "1").billingCompanyId, "koos", "password1", Users.Find(x => x.APSUserId.IdString == "2")));

            List<StatementSpecificFields> StatementFields = new List<StatementSpecificFields>();
            StatementFields.Add(new StatementSpecificFields("Opening Balance", "1200.00"));
            StatementFields.Add(new StatementSpecificFields("Payment Received", "-1200.00"));
            StatementFields.Add(new StatementSpecificFields("Water", "150.00"));
            StatementFields.Add(new StatementSpecificFields("Electicity", "650.00"));
            StatementFields.Add(new StatementSpecificFields("Taxes", "200.00"));
            StatementFields.Add(new StatementSpecificFields("Subtotal", "1000.00"));
            StatementFields.Add(new StatementSpecificFields("VAT", "140.00"));
            StatementFields.Add(new StatementSpecificFields("Total", "1140.00"));
            Statements.Add(new Statement(new StatementId("1"), new StatementCommonFields(123, "Paul", DateTime.Now), new StatementType(1, "Municipal Account"), StatementFields, Users.Find(x => x.APSUserId.IdString == "1"), BillingAccounts.Find(x => x.BillingAccountId.IdString == "1")));

            List<StatementSpecificFields> StatementFields2 = new List<StatementSpecificFields>();
            StatementFields2.Add(new StatementSpecificFields("Opening Balance", "650.00"));
            StatementFields2.Add(new StatementSpecificFields("Payment Received", "-650.00"));
            StatementFields2.Add(new StatementSpecificFields("Clothing Purchase", "150.00"));
            StatementFields2.Add(new StatementSpecificFields("Clothing Purchase", "320.00"));
            StatementFields2.Add(new StatementSpecificFields("Total", "470.00"));
            Statements.Add(new Statement(new StatementId("2"), new StatementCommonFields(532, "Paul", DateTime.Now), new StatementType(1, "Clothing Account"), StatementFields2, Users.Find(x => x.APSUserId.IdString == "1"), BillingAccounts.Find(x => x.BillingAccountId.IdString == "2")));

            List<StatementSpecificFields> StatementFields3 = new List<StatementSpecificFields>();
            StatementFields3.Add(new StatementSpecificFields("Opening Balance", "3250.00"));
            StatementFields3.Add(new StatementSpecificFields("Payment Received", "-500.00"));
            StatementFields3.Add(new StatementSpecificFields("Swipe", "1150.00"));
            StatementFields3.Add(new StatementSpecificFields("Swipe", "4320.00"));
            StatementFields3.Add(new StatementSpecificFields("Interest", "15.05"));
            StatementFields3.Add(new StatementSpecificFields("Total", "8235.05"));
            Statements.Add(new Statement(new StatementId("3"), new StatementCommonFields(787, "Paul", DateTime.Now), new StatementType(1, "Bank Account"), StatementFields3, Users.Find(x => x.APSUserId.IdString == "1"), BillingAccounts.Find(x => x.BillingAccountId.IdString == "3")));
        }

        private static void ClearData()
        {
            Statements.Clear();
            Users.Clear();
            BillingCompanies.Clear();
            BillingAccounts.Clear();
        }

        public static string UserID;
    }
}