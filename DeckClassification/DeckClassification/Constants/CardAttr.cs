namespace DeckClassification.Constants
{
    /// <summary>
    /// カードの持つ属性
    /// </summary>
    /// <remarks>独自に付けるそのカードが持つ属性。カテゴライズ的な値。</remarks>
    public enum CardAttr
    {
        /// <summary>土地加速</summary>
        LandBoost = 1,
        /// <summary>相手に干渉するカード</summary>
        Intervention = 2,
        /// <summary>全体除去</summary>
        MassRemoval = 3,
    }
}
