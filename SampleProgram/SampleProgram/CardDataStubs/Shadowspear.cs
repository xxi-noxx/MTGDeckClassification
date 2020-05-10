using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Shadowspear : CardInfo
    {
        public Shadowspear()
        {
            Name = "Shadowspear";
            ManaCostNumber = 1;
            Types = CardType.Artifact;
        }
    }
}
