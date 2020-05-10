using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Island : CardInfo
    {
        public Island()
        {
            Name = "Island";
            Types = CardType.Land;
        }
    }
}
