using DeckClassification.Entities;

namespace DeckClassification.Services
{
    /// <summary>
    /// 判定処理クラスのインスタンスを生成する機能を提供します
    /// </summary>
    public interface IJudgeServiceFactory
    {
        /// <summary>
        /// デッキリストを渡し、アーキタイプ判定機能を持つクラスのインスタンスを返します
        /// </summary>
        /// <returns></returns>
        IArchetypeJudge CreateArchetypeJudgeService(DeckList deckList);
    }
}
