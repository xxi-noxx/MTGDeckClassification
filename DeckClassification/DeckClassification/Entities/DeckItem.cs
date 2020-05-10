namespace DeckClassification.Entities
{
    /// <summary>
    /// デッキの中に含まれる要素
    /// </summary>
    public class DeckItem
    {
        /// <summary>カード名</summary>
        public string Name { get; set; }
        /// <summary>枚数</summary>
        public int Number { get; set; }
    }
}
