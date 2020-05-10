using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Forest : CardInfo
    {
        public Forest()
        {
            Name = "Forest";
            Types = CardType.Land;
        }
    }
}
