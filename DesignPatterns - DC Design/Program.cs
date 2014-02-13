using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatterns___DC_Design
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var augmentMgr = StatAugmentManager.GetInstance();
            var statDictionary = new Dictionary<StatsType, int>
            {
                {StatsType.Agility, 20},
                {StatsType.Defense, 20},
                {StatsType.Intelegence, 20},
                {StatsType.Strength, 20}
            };

            var stats = new Stats(statDictionary);

            Console.WriteLine(stats);

            try
            {
                StatAugmentCommand test = new StatAugmentCommand(StatsType.CurHp, stats, -5);
                augmentMgr.ReceiveCommand(test);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("");
            }

            StatAugmentCommand augment = new StatAugmentCommand(StatsType.Agility,stats,-5,2,2);
            augmentMgr.ReceiveCommand(augment);
            StatAugmentCommand augment1 = new StatAugmentCommand(StatsType.Strength, stats, -5, 3, 2);
            augmentMgr.ReceiveCommand(augment1);
            StatAugmentCommand augment2 = new StatAugmentCommand(StatsType.Defense, stats, -5, 4, 2);
            augmentMgr.ReceiveCommand(augment2);
            StatAugmentCommand augment3 = new StatAugmentCommand(StatsType.Intelegence, stats, -5, 5, 2);
            augmentMgr.ReceiveCommand(augment3);

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine(stats);
            }

            Console.ReadKey();
        }
    }
}