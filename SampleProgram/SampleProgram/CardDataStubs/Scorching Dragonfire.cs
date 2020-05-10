using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Scorching_Dragonfire : CardInfo
    {
        public Scorching_Dragonfire()
        {
            Name = "Scorching Dragonfire";
            ManaCostNumber = 2;
            Types = CardType.Instant;
            Attributes = new[] { CardAttr.Intervention };
        }
    }
}
