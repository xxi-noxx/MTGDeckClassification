using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Bonecrusher_Giant : CardInfo
    {
        public Bonecrusher_Giant()
        {
            Name = "Bonecrusher Giant";
            ManaCostNumber = 3;
            Types = CardType.Creature;
        }
    }
}
