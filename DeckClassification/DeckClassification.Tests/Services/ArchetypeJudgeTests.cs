using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeckClassification.Entities;

namespace DeckClassification.Services
{
    [TestClass]
    public class ArchetypeJudgeTests
    {
        [TestMethod]
        public void IsCombo_メインボードに荒野の再生と発展発破が含まれている場合はTrue()
        {
            var mainBoard = new[]
            {
                new DeckItem() { Name = "Wilderness Reclamation", Number = 4 },
                new DeckItem() { Name = "Expansion // Explosion", Number = 4 },
                new DeckItem() { Name = "Island", Number = 26 },
                new DeckItem() { Name = "Forest", Number = 26 }
            };
            var deck = new DeckList() { MainBoard = mainBoard };

            var service = new ArchetypeJudge(deck);
            Assert.IsTrue(service.IsCombo());
        }

        [TestMethod]
        public void IsCombo_メインボードに魔女のかまどと大釜の使い魔が含まれている場合はTrue()
        {
            var mainBoard = new[]
                        {
                new DeckItem() { Name = "Cauldron Familiar", Number = 4 },
                new DeckItem() { Name = "Witch's Oven", Number = 4 },
                new DeckItem() { Name = "Swamp", Number = 52 }
            };
            var deck = new DeckList() { MainBoard = mainBoard };

            var service = new ArchetypeJudge(deck);
            Assert.IsTrue(service.IsCombo());
        }

        [TestMethod]
        public void IsCombo_メインボードに何れのコンボパーツも含まれていない場合はFalse()
        {
            var mainBoard = new[]
            {
                new DeckItem() { Name = "Island", Number = 30 },
                new DeckItem() { Name = "Forest", Number = 30 }
            };
            var deck = new DeckList() { MainBoard = mainBoard };

            var service = new ArchetypeJudge(deck);
            Assert.IsFalse(service.IsCombo());
        }
    }
}