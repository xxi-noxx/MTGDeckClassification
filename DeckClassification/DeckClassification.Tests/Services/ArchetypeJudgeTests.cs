using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeckClassification.Entities;
using DeckClassification.Constants;

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
                new DeckItem() { Card = new CardInfo() { Name = "Wilderness Reclamation" }, Number = 4 },
                new DeckItem() { Card = new CardInfo() { Name = "Expansion // Explosion" }, Number = 4 },
                new DeckItem() { Card = new CardInfo() { Name = "Island" }, Number = 26 },
                new DeckItem() { Card = new CardInfo() { Name = "Forest" }, Number = 26 }
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
                new DeckItem() { Card = new CardInfo() { Name = "Cauldron Familiar" }, Number = 4 },
                new DeckItem() { Card = new CardInfo() { Name = "Witch's Oven" }, Number = 4 },
                new DeckItem() { Card = new CardInfo() { Name = "Swamp" }, Number = 52 }
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
                new DeckItem() { Card = new CardInfo() { Name = "Island" }, Number = 30 },
                new DeckItem() { Card = new CardInfo() { Name = "Forest" }, Number = 30 }
            };
            var deck = new DeckList() { MainBoard = mainBoard };

            var service = new ArchetypeJudge(deck);
            Assert.IsFalse(service.IsCombo());
        }

        [TestMethod]
        public void IsRamp_メインボードに土地加速属性のカードが8枚入っている場合はtrue()
        {
            var mainBoard = new[]
            {
                new DeckItem() { Card = new CardInfo() { Name = "Example", Attributes = new[] { CardAttr.LandBoost } }, Number = 8 },
                new DeckItem() { Card = new CardInfo() { Name = "Island" }, Number = 30 },
                new DeckItem() { Card = new CardInfo() { Name = "Forest" }, Number = 30 }
            }; 
            var deck = new DeckList() { MainBoard = mainBoard };

            var service = new ArchetypeJudge(deck);
            Assert.IsTrue(service.IsRamp());
        }

        [TestMethod]
        public void IsRamp_メインボードに土地加速属性のカードが7枚入っている場合はfalse()
        {
            var mainBoard = new[]
            {
                new DeckItem() { Card = new CardInfo() { Name = "Example", Attributes = new[] { CardAttr.LandBoost } }, Number = 7 },
                new DeckItem() { Card = new CardInfo() { Name = "Island" }, Number = 30 },
                new DeckItem() { Card = new CardInfo() { Name = "Forest" }, Number = 30 }
            };
            var deck = new DeckList() { MainBoard = mainBoard };

            var service = new ArchetypeJudge(deck);
            Assert.IsFalse(service.IsRamp());
        }
    }
}