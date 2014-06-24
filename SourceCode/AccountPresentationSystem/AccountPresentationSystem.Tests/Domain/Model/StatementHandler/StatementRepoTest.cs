using AccountPresentationSystem.Domain.Model.StatementHandler;
using AccountPresentationSystem.Infrastructure;
using NUnit.Framework;
using Rhino.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPresentationSystem.Tests.Domain.Model.StatementHandler
{
    class StatementRepoTest
    {
        [Test]
        public void SaveStatementToRepo()
        {
            StatementRepository StateRepo = new StatementRepository();

            bool retVal = StateRepo.SaveStatement();
            
            Assert.IsTrue(retVal);
        }
    }
}
