using DeckClassification.Constants;
using DeckClassification.Entities;
using DeckClassification.Services;

namespace DeckClassification
{
    /// <inheritdoc cref="IClassification"/>
    public class Classification : IClassification
    {
        /// <summary>判定処理クラスのインスタンス生成機能</summary>
        private readonly IJudgeServiceFactory _judgeServiceFactory;

        /// <summary>
        /// デッキ分類クラスのインスタンスを返します
        /// </summary>
        public Classification()
        {
            _judgeServiceFactory = new JudgeServiceFactory();
        }

        /// <summary>
        /// 判定処理クラスのインスタンス生成機能を指定して、デッキ分類クラスのインスタンスを返します
        /// </summary>
        /// <param name="factory"></param>
        public Classification(IJudgeServiceFactory factory)
        {
            _judgeServiceFactory = factory;
        }

        public Archetype GetArchetype(DeckList deckList)
        {
            var service = _judgeServiceFactory.CreateArchetypeJudgeService(deckList);

            // MEMO : 設計的に複数のアーキタイプを返すケースがあるが、今回は1つのアーキタイプを決めるようにする為に判定順番で判定する。
            // コンボ -> ランプ -> 撹乱的アグロ -> アグロ -> ミッドレンジ -> コントロール
            if (service.IsCombo())
            {
                return Archetype.Combo;
            }
            if (service.IsRamp())
            {
                return Archetype.Ramp;
            }
            if (service.IsBeatControl())
            {
                return Archetype.BeatControl;
            }
            if (service.IsAggro())
            {
                return Archetype.Aggro;
            }
            if (service.IsMidrange())
            {
                return Archetype.Midrange;
            }
            if (service.IsControl())
            {
                return Archetype.Control;
            }

            // 何れのアーキタイプにも一致しない場合は分類されないものとして返す
            return Archetype.Other;
        }
    }
}
