using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Sorcerous_Spyglass : CardInfo
    {
        public Sorcerous_Spyglass()
        {
            Name = "Sorcerous Spyglass";
            ManaCostNumber = 2;
            Types = CardType.Artifact;
        }
    }
}
