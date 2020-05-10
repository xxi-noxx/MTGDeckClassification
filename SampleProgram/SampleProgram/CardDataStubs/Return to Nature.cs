using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Return_to_Nature : CardInfo
    {
        public Return_to_Nature()
        {
            Name = "Return to Nature";
            ManaCostNumber = 2;
            Types = CardType.Instant;
        }
    }
}
