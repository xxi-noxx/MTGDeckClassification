using System.Collections.Generic;

namespace DeckClassification.Entities
{
    /// <summary>
    /// デッキリスト
    /// </summary>
    public class DeckList
    {
        /// <summary>メインボード</summary>
        public IEnumerable<DeckItem> Mainboard { get; set; }
        /// <summary>サイドボード</summary>
        public IEnumerable<DeckItem> Sideboard { get; set; }
    }
}
