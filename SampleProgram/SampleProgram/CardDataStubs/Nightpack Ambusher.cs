using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Nightpack_Ambusher : CardInfo
    {
        public Nightpack_Ambusher()
        {
            Name = "Nightpack Ambusher";
            ManaCostNumber = 4;
            Types = CardType.Creature;
        }
    }
}
