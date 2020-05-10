using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class The_Great_Henge : CardInfo
    {
        public The_Great_Henge()
        {
            Name = "The Great Henge";
            ManaCostNumber = 9;
            Types = CardType.Artifact;
        }
    }
}
