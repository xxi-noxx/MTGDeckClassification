using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Mystical_Dispute : CardInfo
    {
        public Mystical_Dispute()
        {
            Name = "Mystical Dispute";
            ManaCostNumber = 3;
            Types = CardType.Instant;
            Attributes = new[] { CardAttr.Intervention };
        }
    }
}
