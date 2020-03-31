using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Problem_Solving_and__Algorithm_Study.HackerRank;
using Problem_Solving_and__Algorithm_Study.LeetCode.Easy;
using Problem_Solving_and__Algorithm_Study.LeetCode.Medium;
using Problem_Solving_and__Algorithm_Study.LeetCode.Hard;
using Problem_Solving_and__Algorithm_Study.LeetCode.Contest;
using Problem_Solving_and__Algorithm_Study.Algorithm.Sort;
using Problem_Solving_and__Algorithm_Study.Codewars;


namespace Problem_Solving_and__Algorithm_Study
{
    public class Tester
    {
        private const string DllFilePath = @"C:\Users\elias\OneDrive\CS-Project\Problem_Solving_and _Algorithm_Study\Debug\Cpp.dll";
        [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl)]
        private extern static int CppTestRun();

        public static int CppTest()
        {
            return CppTestRun();
        }

        public static void LeetCodeTest()
        {
            //Problem7 p = new Problem7();
            //Problem1170 p = new Problem1170();
            //Problem2 p = new Problem2();
            //Problem838 p = new Problem838();
            //Problem240 p = new Problem240();
            //Problem5169 p = new Problem5169();
            //Problem5171 p = new Problem5171();
            //Problem1363 p = new Problem1363();
            //Problem876 p = new Problem876();
            Problem1019 p = new Problem1019();
            //Problem4 p = new Problem4(); //NOT COMPLETED
            //Problem836 p = new Problem836();//NOT COMPLETED
            //Problem141 p = new Problem141();//NOT COMPLETED
            p.Test();
        }
        public static void HackerRankTest()
        {
            //Diagonal_Difference.Test();
            //Staircase.Test();
            //Mini_Max_Sum.Test();
            //Birthday_Cake_Candles.Test();
            //Time_Conversion.Test();
            //Array_DS.Test();
            //_2DArray_DS.Test();
            //High_Security_Strings.Test();
            //Maximum_Streaks.Test();
            //Determine_the_Winner.Test();
            Dynamic_Array.Test(); //NOT COMPLETED
        }

        public static void CodewarsTest()
        {
            //Josephus_Permutation.Test();//Not Completed
            //Sum_of_two_lowest_positive_integers.Test();
            //Equal_Sides_Of_An_Array.Test();
            //Where_my_anagrams_at.Test();
            //Are_they_the_same.Test();
            //Valid_Braces.Test();
            //Playing_with_digits.Test();
            //Sort_the_odd.Test();
            //Shortest_Word.Test();
            Is_a_number_prime.Test();
        }

        public static void Algorithm()
        {
            Merge_Sort sort = new Merge_Sort();
            Binrary_Search_Tree search = new Binrary_Search_Tree();
            //sort.Test();
            search.Test();
        }
    
        static void Main(string[] args)
        {
            //CppTest();
            //HackerRankTest();
            //LeetCodeTest();
            CodewarsTest();
            //Algorithm();
        }
    }
}
