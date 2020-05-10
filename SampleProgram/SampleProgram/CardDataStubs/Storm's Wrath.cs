using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Storm_s_Wrath : CardInfo
    {
        public Storm_s_Wrath()
        {
            Name = "Storm's Wrath";
            ManaCostNumber = 4;
            Types = CardType.Sorcery;
            Attributes = new[] { CardAttr.MassRemoval, CardAttr.Intervention };
        }
    }
}
