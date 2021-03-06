﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study
{
    class DisplayResults
    {
        public static void Display(char[] arr)
        {
            string result = "";
            foreach (var s in arr)
            {
                result += s + " ";
            }
            Console.WriteLine(result);
        }

        public static void Display(string[] arr)
        {
            string result = "";
            foreach(string s in arr)
            {
                result += s + " ";
            }
            Console.WriteLine(result);
        }

        public static void Display(int[] arr)
        {
            string result = "";
            foreach (int s in arr)
            {
                result += s.ToString() + " ";
            }
            Console.WriteLine(result);
        }

        public static void Display(List<int> ll)
        {
            string result = "";
            foreach (int s in ll)
            {
                result += s.ToString() + " ";
            }
            Console.WriteLine(result);
        }

        public static void Display(List<object> ll)
        {
            string result = "";
            foreach (object s in ll)
            {
                result += s.ToString() + " ";
            }
            Console.WriteLine(result);
        }

        public static void Display(List<string> ll)
        {
            string result = "";
            foreach (string s in ll)
            {
                result += s.ToString() + " ";
            }
            Console.WriteLine(result);
        }

        public static void Display<T>(T t) where T: IEnumerable
        {
            string result = "";
            foreach (var s in t)
            {
                result += s.ToString() + " ";
            }
            Console.WriteLine(result);
        }

        public static void Display(int t)
        {
            Console.WriteLine(t);
        }

        public static void Display(bool t)
        {
            Console.WriteLine(t);
        }

        public static void Display(string t)
        {
            Console.WriteLine(t);
        }

        public static void Display(ListNode t)
        {
            Console.WriteLine(t.val);
            while (t.next!=null)
            {
                t = t.next;
                Console.WriteLine(t.val);
            }
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
