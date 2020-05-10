using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Flame_Sweep : CardInfo
    {
        public Flame_Sweep()
        {
            Name = "Flame Sweep";
            ManaCostNumber = 3;
            Types = CardType.Instant;
            Attributes = new[] { CardAttr.Intervention, CardAttr.MassRemoval };
        }
    }
}
