﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountPresentationSystem.Domain.Model.LoadManagement;
using NUnit.Framework;
using Rhino.Mocks;

namespace AccountPresentationSystem.Tests.Domain.Model.LoadManagement
{
    [TestFixture]
    public class LoadManagerTest
    {
        [Test]
        public List<LoadManagerRule> LoadRules()
        {
            var repository = MockRepository.GenerateMock<ILoadManagerRuleRepository>();
            repository.Expect(r => r.LoadRules());

            repository.LoadRules();

            repository.VerifyAllExpectations();

            return new List<LoadManagerRule>();
        }
    }
}