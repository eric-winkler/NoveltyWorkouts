using System;

namespace NoveltyWorkouts
{
    internal class MovementGenerator
    {
         private static string[] _nationalities = new[] {
            "Russian",
            "Polish",
            "Turkish",
            "German",
            "Korean",
            "Samoan",
            "Danish",
            "Bulgarian",
            "Irish",
        };

        private static string[] _bodyParts = new[] {
            "Leg",
            "Arm",
            "Back",
            "Bicep",
            "Hamstring"
        };

        private static string[] _animals = new[] {
            "Bear",
            "Gecko",
            "Leopard",
            "Lion",
            "Eagle",
            "Dolphin",
        };

        private static string[] _movements = new[] {
            "Squat",
            "Lunge",
            "Dip",
            "Twist",
            "Walk",
            "Run",
            "Jump",
            "Crawl",
            "Curl"
        };

        private static Func<string>[] _namingStrategies = new Func<string>[] {
            () => $"{_animals.PickRandom()} {_movements.PickRandom()}",
            () => $"{_nationalities.PickRandom()} {_bodyParts.PickRandom()} {_movements.PickRandom()}",
        };

        public static string Generate() => _namingStrategies.PickRandom()();
    }
}
