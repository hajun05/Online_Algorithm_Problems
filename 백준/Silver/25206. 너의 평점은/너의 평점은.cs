using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace CsWorkspace
{
    class Subject
    {
        private static double[] grade_table = new double[] { 4.0, 3.0, 2.0, 1.0 };
        private static Dictionary<string, double> rating_table = new Dictionary<string, double>
        { 
            { "A+", 4.5 },
            { "A0", 4.0 },
            { "B+", 3.5 },
            { "B0", 3.0 },
            { "C+", 2.5 },
            { "C0", 2.0 },
            { "D+", 1.5 },
            { "D0", 1.0 },
            { "F", 0.0 },
            { "P", 0.0 }
        };

        private string name;
        private double grade;
        private string rating;

        public Subject(string name, double grade, string rating)
        {
            if (name.Length <= 50)
                this.name = name;
            if (grade_table.Contains(grade))
                this.grade = grade;
            if (rating_table.Keys.Contains(rating))
                this.rating = rating;
        }

        public static double AverScore(Subject[] grades)
        {
            double major_sum = 0.0;
            double grade_sum = 0.0;
            byte exep = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i].rating != "P")
                {
                    major_sum += grades[i].grade * rating_table[grades[i].rating];
                    grade_sum += grades[i].grade;
                }
                else
                    exep++;
            }

            return major_sum / grade_sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Subject[] grades = new Subject[20];
            for (byte i = 0; i < 20; i++)
            {
                string[] str = ReadLine().Split(' ');
                grades[i] = new Subject(str[0], Convert.ToDouble(str[1]), str[2]);
            }
            WriteLine("{0:N6}", Subject.AverScore(grades));
        }
    }
}