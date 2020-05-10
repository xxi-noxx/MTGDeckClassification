using DeckClassification.Entities;

namespace DeckClassification.Services
{
    /// <summary>
    /// アーキタイプを判定する処理のインターフェース
    /// </summary>
    interface IArchetypeJudge
    {
        /// <summary>
        /// アグロかどうかを判定します
        /// </summary>
        /// <returns>アグロデッキの場合はtrue</returns>
        bool IsAggro();

        /// <summary>
        /// ミッドレンジかどうかを判定します
        /// </summary>
        /// <returns>ミッドレンジデッキの場合はtrue</returns>
        bool IsMidrange();

        /// <summary>
        /// コントロールかどうかを判定します
        /// </summary>
        /// <returns>コントロールデッキの場合はtrue</returns>
        bool IsControl();

        /// <summary>
        /// 撹乱的アグロかどうかを判定します
        /// </summary>
        /// <returns>撹乱的アグロデッキの場合はtrue</returns>
        bool IsBeatControl();

        /// <summary>
        /// ランプかどうかを判定します
        /// </summary>
        /// <returns>ランプデッキの場合はtrue</returns>
        bool IsRamp();

        /// <summary>
        /// コンボかどうかを判定します
        /// </summary>
        /// <returns>コンボデッキの場合はtrue</returns>
        bool IsCombo();
    }
}
