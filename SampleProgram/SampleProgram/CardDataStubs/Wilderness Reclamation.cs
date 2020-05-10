using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Wilderness_Reclamation : CardInfo
    {
        public Wilderness_Reclamation()
        {
            Name = "Wilderness Reclamation";
            ManaCostNumber = 4;
            Types = CardType.Enchantment;
        }
    }
}
