using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqVsLoops
{
    class TikTokVibesProcessor
    {
        public static List<string> ProcessWithLinq(int[] vibeCheck)
        {
            return vibeCheck
                .Where(vibe => vibe > 10)
                .Select(vibe => vibe * 2)
                .Where(vibe => vibe % 3 == 0)
                .OrderByDescending(vibe => vibe)
                .Take(5)
                .Select(vibe => $"slaps: {vibe}")
                .ToList();
        }

        public static List<string> ProcessWithLoops(int[] vibeCheck)
        {
            var bussin = new List<int>();
            
            for (int i = 0; i < vibeCheck.Length; i++)
            {
                if (vibeCheck[i] > 10)
                {
                    int doubled = vibeCheck[i] * 2;
                    if (doubled % 3 == 0)
                    {
                        bussin.Add(doubled);
                    }
                }
            }

            for (int i = 0; i < bussin.Count - 1; i++)
            {
                for (int j = 0; j < bussin.Count - 1 - i; j++)
                {
                    if (bussin[j] < bussin[j + 1])
                    {
                        int temp = bussin[j];
                        bussin[j] = bussin[j + 1];
                        bussin[j + 1] = temp;
                    }
                }
            }

            var noSkips = new List<string>();
            for (int i = 0; i < Math.Min(5, bussin.Count); i++)
            {
                noSkips.Add($"slaps: {bussin[i]}");
            }

            return noSkips;
        }

        static void Main(string[] args)
        {
            int[] vibeCheck = { 5, 12, 8, 21, 15, 33, 7, 18, 25, 11, 9, 30, 14, 27 };

            Console.WriteLine("vibe check numbers:");
            Console.WriteLine(string.Join(", ", vibeCheck));

            Console.WriteLine("\n=== LINQ hits different ===");
            var linqResults = ProcessWithLinq(vibeCheck);
            foreach (var result in linqResults)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("\n=== Loop version (boomer style) ===");
            var loopResults = ProcessWithLoops(vibeCheck);
            foreach (var result in loopResults)
            {
                Console.WriteLine(result);
            }
        }
    }
}