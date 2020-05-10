namespace DeckClassification.Constants
{
    /// <summary>
    /// アーキタイプ
    /// </summary>
    /// <remarks>M:TG Wiki参照（http://mtgwiki.com/wiki/%E3%82%A2%E3%83%BC%E3%82%AD%E3%82%BF%E3%82%A4%E3%83%97）</remarks>
    public enum Archetype
    {
        /// <summary>どのアーキタイプにも一致しない</summary>
        Other = 0,
        /// <summary>アグロ</summary>
        Aggro = 1,
        /// <summary>ミッドレンジ</summary>
        Midrange = 2,
        /// <summary>コントロール</summary>
        Control = 3,
        /// <summary>撹乱的コントロール</summary>
        BeatControl = 4,
        /// <summary>ランプ</summary>
        Ramp = 5,
        /// <summary>コンボ</summary>
        Combo = 6
    }
}
