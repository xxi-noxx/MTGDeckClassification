using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Fling : CardInfo
    {
        public Fling()
        {
            Name = "Fling";
            ManaCostNumber = 2;
            Types = CardType.Instant;
        }
    }
}
