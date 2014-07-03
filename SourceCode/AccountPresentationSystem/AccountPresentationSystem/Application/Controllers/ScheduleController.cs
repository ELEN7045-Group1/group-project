using AccountPresentationSystem;
using AccountPresentationSystem.Domain.Model.Scheduling;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace AccountPresentationSystem.Application.Controllers
{
    public class ScheduleController : ApiController
    {
        private readonly IScrapeTaskRepository scrapeTaskRepository;

        public ScheduleController(IScrapeTaskRepository _scrapeTaskRepository)
        {
            scrapeTaskRepository = _scrapeTaskRepository;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            List<ScrapeTask> ScrapeTasks = scrapeTaskRepository.GetAllScrapeTask();

            return new string[] { "value1", "value2" };
        }
    }
}
