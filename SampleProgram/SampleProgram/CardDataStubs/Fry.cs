using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Fry : CardInfo
    {
        public Fry()
        {
            Name = "Fry";
            ManaCostNumber = 2;
            Types = CardType.Instant;
            Attributes = new[] { CardAttr.Intervention };
        }
    }
}
