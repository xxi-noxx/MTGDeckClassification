using DeckClassification.Constants;
using DeckClassification.Entities;

namespace SampleProgram.CardDataStubs
{
    class Expansion___Explosion : CardInfo
    {
        public Expansion___Explosion()
        {
            Name = "Expansion // Explosion";
            // TODO : 分割カード場合の仕様考えてなかった...
            ManaCostNumber = 6;
            Types = CardType.Instant;
        }
    }
}
