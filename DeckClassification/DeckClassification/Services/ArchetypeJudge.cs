using System;
using System.Collections.Generic;
using System.Linq;
using DeckClassification.Constants;
using DeckClassification.Entities;

namespace DeckClassification.Services
{
    /// <summary>
    /// アーキタイプを判定する処理
    /// </summary
    public class ArchetypeJudge : IArchetypeJudge
    {
        /// <summary>
        /// 判定するデッキ情報
        /// </summary>
        private readonly DeckList _decklist;

        /// <summary>
        /// デッキ情報を指定して、アーキタイプを判定する処理クラスのインスタンスを生成します
        /// </summary>
        public ArchetypeJudge(DeckList deckList)
        {
            _decklist = deckList;
        }


        /// <summary>
        /// アグロかどうかを判定します
        /// </summary>
        /// <returns>アグロデッキの場合はtrue</returns>
        public bool IsAggro()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 撹乱的アグロかどうかを判定します
        /// </summary>
        /// <returns>撹乱的アグロデッキの場合はtrue</returns>
        public bool IsBeatControl()
        {
            // MEMO : 暫定仕様として、以下の条件を全て満たした場合に錯乱的アグロとする
            // 1. メインデッキに2マナ以下の生物が8枚以上
            // 2. メインデッキに干渉属性を持つカードが8枚以上
            var lowCostCreatureCount = _decklist.MainBoard.Where(x => x.Card.Types.HasFlag(CardType.Creature) && x.Card.ManaCostNumber <= 2).Sum(x => x.Number);
            var interventionCount = _decklist.MainBoard.Where(x => x.Card.Attributes?.Contains(CardAttr.Intervention) ?? false).Sum(x => x.Number);

            return lowCostCreatureCount >= 8 && interventionCount >= 8;
        }

        /// <summary>
        /// コンボかどうかを判定します
        /// </summary>
        /// <returns>コンボデッキの場合はtrue</returns>
        public bool IsCombo()
        {
            // MEMO : DeckItemの比較クラスを用意してあげるほうが望ましい
            Func<IEnumerable<string>, bool> judge = (x => !x.Except(_decklist.MainBoard.Select(y => y.Card.Name)).Any());

            // MEMO : コンボとしてみなす組み合わせのマスタを用意しておくイメージ
            // スタブとして「荒野の再生＆発展発破」と「魔女のかまど＆大釜の使い魔」の２つを用意
            var reclamationComboItem = new[] { "Wilderness Reclamation", "Expansion // Explosion" };
            var ovenCatComboItem = new[] { "Cauldron Familiar", "Witch's Oven" };

            var result = false;
            result |= judge(reclamationComboItem);
            result |= judge(ovenCatComboItem);

            return result;
        }

        /// <summary>
        /// コントロールかどうかを判定します
        /// </summary>
        /// <returns>コントロールデッキの場合はtrue</returns>
        public bool IsControl()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ミッドレンジかどうかを判定します
        /// </summary>
        /// <returns>ミッドレンジデッキの場合はtrue</returns>
        public bool IsMidrange()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ランプかどうかを判定します
        /// </summary>
        /// <returns>ランプデッキの場合はtrue</returns>
        public bool IsRamp()
        {
            // MEMO : メインボードに土地加速の属性を持つカードが何枚入っているかで判定
            var rampCount = _decklist.MainBoard.Where(x => x.Card.Attributes?.Contains(CardAttr.LandBoost) ?? false).Sum(x => x.Number);

            // MEMO : 今回は暫定的に「8枚以上」でランプとする。
            return rampCount >= 8;
        }
    }
}
