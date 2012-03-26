using System.Collections.Generic;

namespace RomanNumerals
{
    public static class RomanNumerals
    {
        public static Dictionary<string, int> Values = new Dictionary<string, int>
                                                            {
                                                                { "M", 1000},
                                                                { "CM", 900},
                                                                { "D", 500},
                                                                { "CD", 400},
                                                                { "C", 100},
                                                                { "XC", 90},
                                                                { "L", 50},
                                                                { "XL", 40},
                                                                { "X", 10},
                                                                { "IX", 9},
                                                                { "V", 5},
                                                                { "IV", 4},
                                                                { "I", 1},
                                                            };

        public static string ToRoman(this int number)
        {
            var result = "";

            foreach (var value in Values)
            {
                while (number >= value.Value)
                {
                    result += value.Key;
                    number -= value.Value;
                }
            }

            return result;
        }
    }
}