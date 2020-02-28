using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Anagram("bugexikjevtubidpulaelsbcqlupwetzyzdvjphn", "lajoipfecfinxjspxmevqxuqyalhrsxcvgsdxxkacspbchrbvvwnvsdtsrdk"));
        }

        static int Anagram(string s1, string s2)
        {
            var s1Anagram = new Dictionary<char, int>();
            var s2Anagram = new Dictionary<char, int>();

            GetAnagram(s1, ref s1Anagram);
            GetAnagram(s2, ref s2Anagram);

            var countDifferences = 0;
            var anagramValue1 = 0;
            var anagramValue2 = 0;

            for (char i = 'a'; i <= 'z'; i++)
            {
                s1Anagram.MyTryGetValue(i, out anagramValue1);
                s2Anagram.MyTryGetValue(i, out anagramValue2);

                var diff = Math.Abs(anagramValue1 - anagramValue2);
                countDifferences += diff;
            }

            return countDifferences;
        }

        static void GetAnagram(string s, ref Dictionary<char, int> stringAsDictionary)
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                stringAsDictionary.Add(i, 0);
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (stringAsDictionary.ContainsKey(s[i]))
                {
                    stringAsDictionary[s[i]]++;
                }
            }
        }
    }

    public static class MyDictionary
    {
        public static bool MyTryGetValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, out TValue value)
        {
            foreach (var item in dictionary)
            {
                if (item.Key.Equals(key))
                {
                    value = item.Value;
                    return true;
                }
            }

            value = default(TValue);
            return false;
        }
    }
}

#region somedumjbshit
// display jagged array
// display hour glass
// save a list with all sums

//var jaggedArray = new int[][]
//{
//    new int[] { 1, 1, 1, 0, 0, 0 },
//    new int[] { 0, 1, 0, 0, 0, 0 },
//    new int[] { 1, 1, 1, 0, 0, 0 },
//    new int[] { 0, 0, 0, 0, 0, 0 },
//    new int[] { 0, 0, 0, 0, 0, 0 },
//    new int[] { 0, 0, 0, 0, 0, 0 }
//};

//Console.WriteLine(PrintArray(jaggedArray));
//}

//static int HourglassSum(int[][] arr)
//{

//}

//static int[][] CreateHourGlass(int[][] array)
//{
//    var hourglass = new int[3][];

//    for (int i = 0; i < 3; i++)
//    {
//        if (i == 1)
//        {
//            for (int j = 1; j < 2; j++)
//            {

//            }
//        }
//        else
//        {
//            for (int j = 0; j < 3; j++)
//            {

//            }
//        }

//    }

//    return hourglass;
//}

//static string PrintArray(int[][] array)
//{
//    var output = new StringBuilder();

//    for (int i = 0; i < array.Length; i++)
//    {
//        for (int j = 0; j < array[i].Length; j++)
//        {
//            output.Append($"{array[i][j]} ");
//        }
//        output.AppendLine();
//    }

//    return output.ToString();
//}
#endregion