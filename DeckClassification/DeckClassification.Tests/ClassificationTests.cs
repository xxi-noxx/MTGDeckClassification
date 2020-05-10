using DeckClassification.Constants;
using DeckClassification.Entities;
using DeckClassification.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DeckClassification
{
    [TestClass()]
    public class ClassificationTests
    {
        private IJudgeServiceFactory _judgeServiceFacMock;
        private Mock<IArchetypeJudge> _archetypeJudgeMock;

        [TestInitialize]
        public void テスト初期処理()
        {
            _archetypeJudgeMock = new Mock<IArchetypeJudge>();

            // Factoryのモックは上記Mockを返すよう仕込んでおく
            var facMock = new Mock<IJudgeServiceFactory>();
            facMock.Setup(x => x.CreateArchetypeJudgeService(It.IsAny<DeckList>())).Returns(_archetypeJudgeMock.Object);
            _judgeServiceFacMock = facMock.Object;
        }

        [TestMethod()]
        public void GetArchetypeTest_IsComboがtrueの場合はコンボアーキタイプが返る()
        {
            // Comboに当てはまる場合は他のアーキタイプが成立してもコンボ
            _archetypeJudgeMock.SetReturnsDefault(true);
            _archetypeJudgeMock.Setup(x => x.IsCombo()).Returns(true);

            var service = new Classification(_judgeServiceFacMock);
            var actual = service.GetArchetype(new DeckList());

            Assert.AreEqual(Archetype.Combo, actual);
        }

        [TestMethod]
        public void GetArchetypeTest_IsRampがtrueの場合はランプアーキタイプが返る()
        {
            // Comboの優先度が高いため、コンボ判定をfalseにしておく
            _archetypeJudgeMock.Setup(x => x.IsCombo()).Returns(false);
            _archetypeJudgeMock.Setup(x => x.IsRamp()).Returns(true);

            var service = new Classification(_judgeServiceFacMock);
            var actual = service.GetArchetype(new DeckList());

            Assert.AreEqual(Archetype.Ramp, actual);
        }

        [TestMethod]
        public void GetArchetypeTest_IsBeatControlがtrueの場合は撹乱的アグロアーキタイプが返る()
        {
            // ComboとRampの優先度が高いため、コンボ判定をfalseにしておく
            _archetypeJudgeMock.Setup(x => x.IsCombo()).Returns(false);
            _archetypeJudgeMock.Setup(x => x.IsRamp()).Returns(false);
            _archetypeJudgeMock.Setup(x => x.IsBeatControl()).Returns(true);

            var service = new Classification(_judgeServiceFacMock);
            var actual = service.GetArchetype(new DeckList());

            Assert.AreEqual(Archetype.BeatControl, actual);
        }

        [TestMethod]
        public void GetArchetypeTest_IsAggroがtrueの場合はアグロアーキタイプが返る()
        {
            // Combo、Ramp、BeatControlの優先度が高いため、コンボ判定をfalseにしておく
            _archetypeJudgeMock.Setup(x => x.IsCombo()).Returns(false);
            _archetypeJudgeMock.Setup(x => x.IsRamp()).Returns(false);
            _archetypeJudgeMock.Setup(x => x.IsBeatControl()).Returns(false);
            _archetypeJudgeMock.Setup(x => x.IsAggro()).Returns(true);

            var service = new Classification(_judgeServiceFacMock);
            var actual = service.GetArchetype(new DeckList());

            Assert.AreEqual(Archetype.Aggro, actual);
        }

        [TestMethod]
        public void GetArchetypeTest_IsMidrangeがtrueの場合はミッドレンジアーキタイプが返る()
        {
            // Combo、Ramp、BeatControl、Aggroの優先度が高いため、コンボ判定をfalseにしておく
            _archetypeJudgeMock.Setup(x => x.IsCombo()).Returns(false);
            _archetypeJudgeMock.Setup(x => x.IsRamp()).Returns(false);
            _archetypeJudgeMock.Setup(x => x.IsBeatControl()).Returns(false);
            _archetypeJudgeMock.Setup(x => x.IsAggro()).Returns(false);
            _archetypeJudgeMock.Setup(x => x.IsMidrange()).Returns(true);

            var service = new Classification(_judgeServiceFacMock);
            var actual = service.GetArchetype(new DeckList());

            Assert.AreEqual(Archetype.Midrange, actual);
        }

        [TestMethod]
        public void GetArchetypeTest_IsControlがtrueの場合はコントロールアーキタイプが返る()
        {
            // Combo、Ramp、BeatControl、Aggro、Midrangeの優先度が高いため、コンボ判定をfalseにしておく
            _archetypeJudgeMock.Setup(x => x.IsCombo()).Returns(false);
            _archetypeJudgeMock.Setup(x => x.IsRamp()).Returns(false);
            _archetypeJudgeMock.Setup(x => x.IsBeatControl()).Returns(false);
            _archetypeJudgeMock.Setup(x => x.IsAggro()).Returns(false);
            _archetypeJudgeMock.Setup(x => x.IsMidrange()).Returns(false);
            _archetypeJudgeMock.Setup(x => x.IsControl()).Returns(true);

            var service = new Classification(_judgeServiceFacMock);
            var actual = service.GetArchetype(new DeckList());

            Assert.AreEqual(Archetype.Control, actual);
        }

        [TestMethod]
        public void GetArchetypeTest_いずれのアーキタイプ判定処理もfalseの場合は未分類アーキタイプが返る()
        {
            _archetypeJudgeMock.SetReturnsDefault(false);

            var service = new Classification(_judgeServiceFacMock);
            var actual = service.GetArchetype(new DeckList());

            Assert.AreEqual(Archetype.Other, actual);
        }
    }
}