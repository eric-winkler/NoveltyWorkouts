using System;
using System.Collections.Generic;

namespace NoveltyWorkouts
{
    internal static class RandomExtensions
    {
        private static Random random = new Random();
        public static T PickRandom<T>(this IEnumerable<T> choices) => choices.OrderBy(o => random.Next()).First();
    }
}
