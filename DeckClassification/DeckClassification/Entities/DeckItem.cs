namespace DeckClassification.Entities
{
    /// <summary>
    /// デッキの中に含まれる要素
    /// </summary>
    public class DeckItem
    {
        /// <summary>カード情報</summary>
        public CardInfo Card { get; set; }
        /// <summary>枚数</summary>
        public int Number { get; set; }
    }
}
