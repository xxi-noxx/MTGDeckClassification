using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Growth_Spiral : CardInfo
    {
        public Growth_Spiral()
        {
            Name = "Growth Spiral";
            ManaCostNumber = 2;
            Types = CardType.Instant;
            Attributes = new[] { CardAttr.LandBoost };
        }
    }
}
