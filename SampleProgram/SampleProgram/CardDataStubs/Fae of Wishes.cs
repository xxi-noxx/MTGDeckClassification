using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Fae_of_Wishes : CardInfo
    {
        public Fae_of_Wishes()
        {
            Name = "Fae of Wishes";
            ManaCostNumber = 2;
            Types = CardType.Creature;
        }
    }
}
