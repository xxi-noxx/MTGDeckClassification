using DeckClassification.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace SampleProgram
{
    // TODO : メジャーなフォーマットから独自のデッキデータ形式へのマッピングクラスは、別途用意しておいた方がいいと思うところなので作り込みは割愛
    class LoadDeckList
    {
        /// <summary>
        /// Magic Onlineデッキリスト 1行毎のフォーマット
        /// </summary>
        private Regex _moListLineFormat = new Regex("^(?<number>[0-9]+) (?<name>.+)$");

        /// <summary>
        /// Magic Onlineのデッキリスト形式になっているStreamデータを読み込んで、デッキリストを返します
        /// </summary>
        /// <param name="deck">デッキリスト（MO形式）</param>
        /// <returns>デッキリスト</returns>
        public DeckList LoadMagicOnlineDeckList(StreamReader deck)
        {
            var mainboard = new List<DeckItem>();
            var sideboard = new List<DeckItem>();

            var isSide = false;
            while (deck.Peek() != -1)
            {
                var item = deck.ReadLine();
                // 空行はSkip
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }

                // 値が"Sideboard"の場合はサイドフラグON
                if (item.ToLower() == "sideboard")
                {
                    isSide = true;
                }

                // レコードの検証＆カード情報取得
                if (!_moListLineFormat.IsMatch(item))
                {
                    continue;
                }
                var matchedItem = _moListLineFormat.Match(item);
                var number = int.Parse(matchedItem.Groups["number"].Value);
                var name = matchedItem.Groups["name"].Value;

                // カード情報設定
                // MEMO : スタブのカードデータに登録されていないカードが指定された場合は例外
                if (isSide)
                {
                    sideboard.Add(new DeckItem() { Number = number, Card = CardMaster.CardData[name] });
                }
                else
                {
                    mainboard.Add(new DeckItem() { Number = number, Card = CardMaster.CardData[name] });
                }
            }

            return new DeckList() { Mainboard = mainboard, Sideboard = sideboard };
        }
    }
}
