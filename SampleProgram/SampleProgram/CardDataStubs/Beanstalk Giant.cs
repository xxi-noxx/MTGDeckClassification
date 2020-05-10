using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Beanstalk_Giant : CardInfo
    {
        public Beanstalk_Giant()
        {
            Name = "Beanstalk Giant";
            ManaCostNumber = 7;
            Types = CardType.Creature;
            Attributes = new[] { CardAttr.LandBoost };
        }
    }
}
