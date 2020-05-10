using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Once_and_Future : CardInfo
    {
        public Once_and_Future()
        {
            Name = "Once and Future";
            ManaCostNumber = 4;
            Types = CardType.Instant;
        }
    }
}
