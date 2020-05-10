using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Claim_the_Firstborn : CardInfo
    {
        public Claim_the_Firstborn()
        {
            Name = "Claim the Firstborn";
            ManaCostNumber = 1;
            Types = CardType.Sorcery;
        }
    }
}
