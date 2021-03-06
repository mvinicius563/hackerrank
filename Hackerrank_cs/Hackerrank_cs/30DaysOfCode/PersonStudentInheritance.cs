﻿using System;

namespace Hackerrank_cs._30DaysOfCode
{
    class PersonStudentInheritance
    {
        public PersonStudentInheritance()
        {

        }

        class Student : Person
        {
            private int[] testScores;
            public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id)
            {
                this.testScores = scores;
            }

            public char calculate() {
                var avg = System.Linq.Enumerable.Average(testScores);
                if (avg >= 90) return 'O';
                if (avg >= 80) return 'E';
                if (avg >= 70) return 'A';
                if (avg >= 55) return 'P';
                if (avg >= 40) return 'D';
                return 'T';
            }
        }

        class Person
        {
            protected string firstName;
            protected string lastName;
            protected int id;

            public Person() { }
            public Person(string firstName, string lastName, int identification)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.id = identification;
            }
            public void printPerson()
            {
                Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
            }
        }        
    }    
}
