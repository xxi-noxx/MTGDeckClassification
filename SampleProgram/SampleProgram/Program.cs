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

            var deck = new TemurReclamation();
            var archetype = classification.GetArchetype(deck);

            Console.WriteLine($"Temur Reclamation のアーキタイプは {archetype} です。");
            Console.ReadKey();
        }
    }
}
