using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Shark_Typhoon : CardInfo
    {
        public Shark_Typhoon()
        {
            Name = "Shark Typhoon";
            ManaCostNumber = 6;
            Types = CardType.Enchantment;
        }
    }
}
