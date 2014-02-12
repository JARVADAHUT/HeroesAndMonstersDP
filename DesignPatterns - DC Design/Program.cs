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

            StatAugmentCommand augment = new StatAugmentCommand(PublicEnums.StatsType.Agility,stats,-5,0,2);
            augmentMgr.ReceiveCommand(augment);

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(stats);
            }

            Console.ReadKey();
        }
    }
}