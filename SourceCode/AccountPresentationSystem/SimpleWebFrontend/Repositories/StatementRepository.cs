using AccountPresentationSystem.Domain.Model.APSUser;
using AccountPresentationSystem.Domain.Model.StatementHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace SimpleWebFrontend.Repositories
{
    public class StatementRepository : IStatementRepository
    {
        public async Task<List<FakeStatement>> GetAllStatementsPerUser(string UserID)
        {
            List<FakeStatement> retList = new List<FakeStatement>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Properties.Settings.Default.APSServiceURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("api/statements/");
                if (response.IsSuccessStatusCode)
                {
                    retList = await response.Content.ReadAsAsync<List<FakeStatement>>();
                }
            }
            return retList;
        }

        public async Task<FakeStatement> GetSpecificStatement(string StatementId)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Properties.Settings.Default.APSServiceURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("api/statements/" + StatementId);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<FakeStatement>();
                }
            }
            return null;
        }
    }
}