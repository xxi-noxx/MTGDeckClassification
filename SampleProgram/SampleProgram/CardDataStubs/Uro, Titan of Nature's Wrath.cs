using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Uro__Titan_of_Nature_s_Wrath : CardInfo
    {
        public Uro__Titan_of_Nature_s_Wrath()
        {
            Name = "";
            ManaCostNumber = 3;
            Types = CardType.Creature;
            Attributes = new[] { CardAttr.LandBoost };
        }
    }
}
