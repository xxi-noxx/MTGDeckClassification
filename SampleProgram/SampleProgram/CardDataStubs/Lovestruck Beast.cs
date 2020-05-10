using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Lovestruck_Beast : CardInfo
    {
        public Lovestruck_Beast()
        {
            Name = "Lovestruck Beast";
            ManaCostNumber = 3;
            Types = CardType.Creature;
        }
    }
}
