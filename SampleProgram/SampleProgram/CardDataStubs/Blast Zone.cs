using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Blast_Zone : CardInfo
    {
        public Blast_Zone()
        {
            Name = "Blast Zone";
            Types = CardType.Land;
            Attributes = new[] { CardAttr.Intervention };
        }
    }
}
