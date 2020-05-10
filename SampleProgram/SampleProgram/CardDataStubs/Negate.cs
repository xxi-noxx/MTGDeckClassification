using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Negate : CardInfo
    {
        public Negate()
        {
            Name = "Negate";
            ManaCostNumber = 2;
            Types = CardType.Instant;
            Attributes = new[] { CardAttr.Intervention };
        }
    }
}
