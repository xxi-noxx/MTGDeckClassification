using DeckClassification;
using SampleProgram.Decks;
using System;

namespace SampleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            IClassification classification = new Classification();

            // 今回はネットに乗っていたデッキのカード情報から手打ちで用意
            // デッキ情報のインポートやカードデータの準備はアーキタイプ判定とは別の機能なので今回は実装無し。
            var deck = new TemurReclamation();
            var archetype = classification.GetArchetype(deck);

            Console.WriteLine($"Temur Reclamation のアーキタイプは {archetype} です。");
            Console.ReadKey();
        }
    }
}
