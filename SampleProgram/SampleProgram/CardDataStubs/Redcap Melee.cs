using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Redcap_Melee : CardInfo
    {
        public Redcap_Melee()
        {
            Name = "Redcap Melee";
            ManaCostNumber = 1;
            Types = CardType.Instant;
            Attributes = new[] { CardAttr.Intervention };
        }
    }
}
