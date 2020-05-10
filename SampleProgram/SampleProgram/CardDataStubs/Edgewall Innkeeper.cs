using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Edgewall_Innkeeper : CardInfo
    {
        public Edgewall_Innkeeper()
        {
            Name = "Edgewall Innkeeper";
            ManaCostNumber = 1;
            Types = CardType.Creature;
        }
    }
}
