using System.Collections.Generic;

namespace DeckClassification.Entities
{
    /// <summary>
    /// デッキリスト
    /// </summary>
    public class DeckList
    {
        /// <summary>メインボード</summary>
        public IEnumerable<DeckItem> MainBoard { get; set; }
        /// <summary>サイドボード</summary>
        public IEnumerable<DeckItem> SideBoard { get; set; }
    }
}
