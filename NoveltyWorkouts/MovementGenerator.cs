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
            "Spanish",
            "Hungarian",
            "Romanian",
            "Mongolian"
        };

        private static string[] _bodyParts = new[] {
            "Leg",
            "Arm",
            "Back",
            "Bicep",
            "Hamstring",
            "Calf",
            "Forearm",
            "Abdominal"
        };

        private static string[] _animals = new[] {
            "Bear",
            "Gecko",
            "Leopard",
            "Lion",
            "Eagle",
            "Dolphin",
            "Donkey",
            "Gorilla"
        };

        private static string[] _movements = new[] {
            "Squat",
            "Lunge",
            "Dip",
            "Twist",
            "Walk",
            "Sprint",
            "Jump",
            "Crawl",
            "Curl",
            "Hold"
        };

        private static Func<string>[] _namingStrategies = new Func<string>[] {
            () => $"{_animals.PickRandom()} {_movements.PickRandom()}",
            () => $"{_nationalities.PickRandom()} {_bodyParts.PickRandom()} {_movements.PickRandom()}",
        };

        public static string Generate() => _namingStrategies.PickRandom()();
    }
}
