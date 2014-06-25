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
        public async Task<List<Statement>> GetAllStatementsPerUser(APSUserId UserID)
        {
            List<Statement> retList = new List<Statement>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Properties.Settings.Default.APSServiceURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("api/statements/");
                if (response.IsSuccessStatusCode)
                {
                    retList = await response.Content.ReadAsAsync<List<Statement>>();
                }
            }
            return retList;
        }
    }
}