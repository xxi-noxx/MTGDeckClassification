using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Aether_Gust : CardInfo
    {
        public Aether_Gust()
        {
            Name = "Aether Gust";
            ManaCostNumber = 2;
            Types = CardType.Instant;
            Attributes = new[] { CardAttr.Intervention };
        }
    }
}
