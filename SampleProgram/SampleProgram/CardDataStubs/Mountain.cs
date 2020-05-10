using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Mountain : CardInfo
    {
        public Mountain()
        {
            Name = "Mountain";
            Types = CardType.Land;
        }
    }
}
