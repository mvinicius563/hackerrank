﻿using System;
using System.Collections.Generic;

namespace Hackerrank_cs._30DaysOfCode
{
    class PalindromesQueueAndStack
    {
        Queue<char> q = new Queue<char>();
        Stack<char> s = new Stack<char>();

        public void pushCharacter(char ch)
        {
            s.Push(ch);
        }

        public void enqueueCharacter(char ch)
        {
            q.Enqueue(ch);
        }

        public char popCharacter()
        {
            return s.Pop();
        }

        public char dequeueCharacter()
        {
            return q.Dequeue();
        }

        public PalindromesQueueAndStack()
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            PalindromesQueueAndStack obj = new PalindromesQueueAndStack();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}
