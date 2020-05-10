using DeckClassification.Entities;
using SampleProgram.CardDataStubs;
using System.Collections.Generic;

namespace SampleProgram.Decks
{
    /// <summary>
    /// ティムール荒野の再生デッキ
    /// </summary>
    /// <remarks>https://www.mtggoldfish.com/deck/3000939#paper</remarks>
    public class TemurReclamation : DeckList
    {
        public TemurReclamation()
        {
            Mainboard = CreateMainboard();
            Sideboard = CreateSideborad();
        }

        private IEnumerable<DeckItem> CreateMainboard()
        {
            var list = new List<DeckItem>();
            // Creature
            list.Add(new DeckItem() { Number = 3, Card = new Uro__Titan_of_Nature_s_Wrath() });

            // Spells
            list.Add(new DeckItem() { Number = 4, Card = new Opt() });
            list.Add(new DeckItem() { Number = 4, Card = new Growth_Spiral() });
            list.Add(new DeckItem() { Number = 2, Card = new Negate() });
            list.Add(new DeckItem() { Number = 2, Card = new Scorching_Dragonfire() });
            list.Add(new DeckItem() { Number = 1, Card = new Thassa_s_Intervention() });
            list.Add(new DeckItem() { Number = 3, Card = new Mystical_Dispute() });
            list.Add(new DeckItem() { Number = 1, Card = new Chemister_s_Insight() });
            list.Add(new DeckItem() { Number = 4, Card = new Expansion___Explosion() });

            // Enchantments
            list.Add(new DeckItem() { Number = 4, Card = new Wilderness_Reclamation() });
            list.Add(new DeckItem() { Number = 4, Card = new Shark_Typhoon() });
            
            // Lands
            list.Add(new DeckItem() { Number = 1, Card = new Blast_Zone() });
            list.Add(new DeckItem() { Number = 3, Card = new Castle_Vantress() });
            list.Add(new DeckItem() { Number = 4, Card = new Fabled_Passage() });
            list.Add(new DeckItem() { Number = 2, Card = new Forest() });
            list.Add(new DeckItem() { Number = 2, Card = new Island() });
            list.Add(new DeckItem() { Number = 2, Card = new Ketria_Triome() });
            list.Add(new DeckItem() { Number = 1, Card = new Mountain() });
            list.Add(new DeckItem() { Number = 4, Card = new Steam_Vents() });
            list.Add(new DeckItem() { Number = 4, Card = new Stomping_Ground() });
            list.Add(new DeckItem() { Number = 1, Card = new Temple_of_Epiphany() });

            return list;
        }

        private IEnumerable<DeckItem> CreateSideborad()
        {
            var list = new List<DeckItem>();

            list.Add(new DeckItem() { Number = 2, Card = new Aether_Gust() });
            list.Add(new DeckItem() { Number = 2, Card = new Fry() });
            list.Add(new DeckItem() { Number = 2, Card = new Negate() });
            list.Add(new DeckItem() { Number = 2, Card = new Scorching_Dragonfire() });
            list.Add(new DeckItem() { Number = 3, Card = new Flame_Sweep() });
            list.Add(new DeckItem() { Number = 1, Card = new Mystical_Dispute() });
            list.Add(new DeckItem() { Number = 1, Card = new Chemister_s_Insight() });
            list.Add(new DeckItem() { Number = 2, Card = new Nightpack_Ambusher() });

            return list;
        }
    }
}
