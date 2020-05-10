using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Unsummon : CardInfo
    {
        public Unsummon()
        {
            Name = "Unsummon";
            ManaCostNumber = 1;
            Types = CardType.Instant;
            Attributes = new[] { CardAttr.Intervention };
        }
    }
}
