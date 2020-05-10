using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Lucky_Clover : CardInfo
    {
        public Lucky_Clover()
        {
            Name = "Lucky Clover";
            ManaCostNumber = 2;
            Types = CardType.Artifact;
        }
    }
}
