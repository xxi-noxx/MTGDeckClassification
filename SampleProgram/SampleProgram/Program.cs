using DeckClassification;
using DeckClassification.Entities;
using System;
using System.IO;
using System.Linq;

namespace SampleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!args.Any())
            {
                Console.WriteLine("ファイルが指定されていません");
                Console.ReadKey();
                return;
            }

            IClassification classification = new Classification();

            DeckList deck;
            using (var sr = new StreamReader(args[0]))
            {
                var loader = new LoadDeckList();
                deck = loader.LoadMagicOnlineDeckList(sr);
            }

            var archetype = classification.GetArchetype(deck);

            // アーキタイプ名書き出し
            using (var sw = new StreamWriter(@".\result.txt", true))
            {
                sw.WriteLine($"{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}：{args[0]} のアーキタイプは {archetype} です。");
            }
            Console.WriteLine($"{args[0]} のアーキタイプは {archetype} です。");
            Console.ReadKey();
        }
    }
}
