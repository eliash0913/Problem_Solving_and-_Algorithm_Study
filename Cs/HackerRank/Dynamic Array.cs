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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//https://www.hackerrank.com/challenges/dynamic-array/problem?h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
namespace Problem_Solving_and__Algorithm_Study.HackerRank
{
    /***** WORKING *****/
    class Dynamic_Array
    {
        public static List<int> DynamicArray(int n, List<List<int>> queries)
        {
            List<List<int>> seqList = new List<List<int>>();
            int lastAnswer = 0;
            foreach(var i in queries)
            {
                int qn = i[0];
                int x = i[1];
                int y = i[2];
                if(qn == 1)
                {
                    int seq = (x ^ lastAnswer) % n;
                }
                else if(qn == 2)
                {

                }
            }
            return null;
        }




        /*public static List<int> DynamicArray(int n, List<List<int>> queries)
            {
            List<int> seqList = new List<int>(n);
            List<int> s0 = new List<int>();
            List<int> s1 = new List<int>();
            int lastAnswer = 0;
            foreach(var query in queries)
            {
                int qn = query[0];
                int x = query[1];
                int y = query[2];
                int seq = (x ^ lastAnswer) % n;
                if(qn == 1)
                {
                    if(seq == 0)
                    {
                        s0.Add(y);
                    }
                    if(seq == 1)
                    {
                        s1.Add(y);
                    }
                }
                else if(qn == 2)
                {
                    if(seq == 0)
                    {
                        lastAnswer = s0[s0.Count-1];
                    }
                    if(seq == 1)
                    {
                        lastAnswer = s1[s1.Count-1];
                    }
                    seqList.Add(lastAnswer);
                }
            }
            return seqList;
        }*/
        
        public static void Test()
        {
            int sample = 2;
            List<List<int>> queries = new List<List<int>>();
            queries.Add(new List<int> { 1, 0, 5 });
            queries.Add(new List<int> { 1, 1, 7 });
            queries.Add(new List<int> { 1, 0, 3 });
            queries.Add(new List<int> { 2, 1, 0 });
            queries.Add(new List<int> { 2, 1, 1 });
            DisplayResults.Display(DynamicArray(sample, queries));
        }
    }
}
