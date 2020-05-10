using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Nissa__Who_Shakes_the_World : CardInfo
    {
        public Nissa__Who_Shakes_the_World()
        {
            Name = "Nissa, Who Shakes the World";
            ManaCostNumber = 5;
            Types = CardType.Planeswalker;
        }
    }
}
