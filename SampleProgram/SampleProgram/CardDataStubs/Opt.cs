using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Opt : CardInfo
    {
        public Opt()
        {
            Name = "Opt";
            ManaCostNumber = 1;
            Types = CardType.Instant;
        }
    }
}
