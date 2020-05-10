using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeckClassification.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeckClassification.Services
{
    [TestClass()]
    public class JudgeServiceFactoryTests
    {
        [TestMethod()]
        public void CreateArchetypeJudgeService_ArchetypeJudgeクラスのインスタンスが返る()
        {
            var factory = new JudgeServiceFactory();
            var actual = factory.CreateArchetypeJudgeService(new Entities.DeckList());

            Assert.IsInstanceOfType(actual, typeof(ArchetypeJudge));
        }
    }
}