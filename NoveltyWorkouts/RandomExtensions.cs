using System;
using System.Collections.Generic;
using System.Linq;

namespace NoveltyWorkouts
{
    internal static class RandomExtensions
    {
        private static Random _random = new Random();
        public static T PickRandom<T>(this IEnumerable<T> choices) => choices.OrderBy(o => _random.Next()).First();
    }
}
