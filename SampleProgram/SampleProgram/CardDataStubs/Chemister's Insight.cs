using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Chemister_s_Insight : CardInfo
    {
        public Chemister_s_Insight()
        {
            Name = "Chemister's Insight";
            ManaCostNumber = 4;
            Types = CardType.Instant;
        }
    }
}
