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
            var statDictionary = new Dictionary<PublicEnums.StatsType, int>
            {
                {PublicEnums.StatsType.Agility, 20},
                {PublicEnums.StatsType.Defense, 20},
                {PublicEnums.StatsType.Intelegence, 20},
                {PublicEnums.StatsType.Strength, 20}
            };

            var stats = new Stats(statDictionary);

            Console.WriteLine(stats);

            StatAugmentCommand augment = new StatAugmentCommand(PublicEnums.StatsType.Agility,stats,-5,2,2);
            augmentMgr.ReceiveCommand(augment);
            StatAugmentCommand augment1 = new StatAugmentCommand(PublicEnums.StatsType.Strength, stats, -5, 3, 2);
            augmentMgr.ReceiveCommand(augment1);
            StatAugmentCommand augment2 = new StatAugmentCommand(PublicEnums.StatsType.Defense, stats, -5, 3, 2);
            augmentMgr.ReceiveCommand(augment2);
            StatAugmentCommand augment3 = new StatAugmentCommand(PublicEnums.StatsType.Intelegence, stats, -5, 2, 2);
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