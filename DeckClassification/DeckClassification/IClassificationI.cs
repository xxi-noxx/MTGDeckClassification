using DeckClassification.Entities;

namespace DeckClassification
{
    /// <summary>
    /// デッキの分類を行う機能を提供します
    /// </summary>
    public interface IClassification
    {
        /// <summary>
        /// デッキのアーキタイプを取得します
        /// </summary>
        /// <param name="decklist">デッキリスト</param>
        /// <returns>分析した結果のアーキタイプ</returns>
        Constants.Archetype GetArchetype(DeckList deckList);
    }
}
