using System;
using System.Collections.Generic;
using System.Text;

namespace DeckClassification.Constants
{
    /// <summary>
    /// カードの種別
    /// </summary>
    /// <remarks>M:TG Wiki参照（http://mtgwiki.com/wiki/%E3%82%AB%E3%83%BC%E3%83%89%E3%82%BF%E3%82%A4%E3%83%97#.E3.82.AB.E3.83.BC.E3.83.89.E3.83.BB.E3.82.BF.E3.82.A4.E3.83.97.E4.B8.80.E8.A6.A7）</remarks>
    /// <example>
    /// 限られた数しかないのでFlagsで管理。複数の種別を持つ場合は論理和で持つ。
    /// <code>
    /// // 部族クリーチャーの場合
    /// var types = CardType.Creature | CardType.Tribal;
    /// </code>
    /// </example>
    [Flags]
    public enum CardType
    {
        /// <summary>土地</summary>
        Land = 1 << 0,
        /// <summary>クリーチャー</summary>
        Creature = 1 << 1,
        /// <summary>エンチャント</summary>
        Enchantment = 1 << 2,
        /// <summary>アーティファクト</summary>
        Artifact = 1 << 3,
        /// <summary>インスタンス</summary>
        Instant = 1 << 4,
        /// <summary>ソーサリー</summary>
        Sorcery = 1 << 5,
        /// <summary>部族</summary>
        Tribal = 1 << 6,
        /// <summary>プレインズウォーカー</summary>
        Planeswalker = 1 << 7
    }
}
