using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//https://www.hackerrank.com/challenges/dynamic-array/problem?h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
namespace Problem_Solving_and__Algorithm_Study.HackerRank
{
    class Dynamic_Array
    {
        /// <summary>
        /// Create a list, seqList, of N empty sequences, where each sequence is indexed from 0 to N-1. 
        /// The elements within each of the N sequences also use 0-indexing.
        /// Create an integer, lastAnswer, and initialize it to 0.
        /// The 2 types of queries that can be performed on your list of sequences (seqList) are described below:
        /// Query: 1 x y
        /// 1. Find the sequence, seq , at index((x XOR lastAnswer) % N ) in seqList.
        /// 2. Append integer y to sequence seq.
        /// Query: 2 x y
        /// 1. Find the sequence, seq , at index ((x XOR lastAnswer)%N) in seqList.
        /// 2. Find the value of element y % size in seq (where size is the size of seq) and assign it to lastAnswer.
        /// 3. Print the new value of lastAnswer on a new line
        /// </summary>
        /// <param name="n"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public static List<int> DynamicArray(int n, List<List<int>> queries)
        {
            int num = queries[0][0];

            List<int> seqList = new List<int>();


            return seqList;
        }
        
        public static void Test()
        {
            int sample = 0;
            List<List<int>> queries = new List<List<int>>();
            DisplayResults.Display(DynamicArray(sample, queries));
        }
    }
}
