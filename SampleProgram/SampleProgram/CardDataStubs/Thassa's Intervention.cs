using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Thassa_s_Intervention : CardInfo
    {
        public Thassa_s_Intervention()
        {
            Name = "Thassa's Intervention";
            ManaCostNumber = 2;
            Types = CardType.Instant;
            Attributes = new[] { CardAttr.Intervention };
        }
    }
}
