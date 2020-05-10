using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Brazen_Borrower : CardInfo
    {
        public Brazen_Borrower()
        {
            Name = "Brazen Borrower";
            ManaCostNumber = 3;
            Types = CardType.Creature;
            Attributes = new[] { CardAttr.Intervention };
        }
    }
}
