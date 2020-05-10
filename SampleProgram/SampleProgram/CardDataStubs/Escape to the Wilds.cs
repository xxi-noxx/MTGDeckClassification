using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Escape_to_the_Wilds : CardInfo
    {
        public Escape_to_the_Wilds()
        {
            Name = "Escape to the Wilds";
            ManaCostNumber = 5;
            Types = CardType.Sorcery;
        }
    }
}
