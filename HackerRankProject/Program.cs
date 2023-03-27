using System.Linq;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;


namespace HackerRankProject
{

    class Program
    {
        public static List<int> gradingStudents(List<int> grades)
        {
          
            List<int> studentsGrades = new List<int>();
            int moduloGrade;
            int nextMultiply; 

            foreach(int g in grades)
            {
                if(g < 40)
                {
                    studentsGrades.Add(g);
                }


                moduloGrade = g % 5;

                if(moduloGrade !=0)
                {
                    nextMultiply = g + (5 - (moduloGrade)); 
                    if(nextMultiply - g < 3)
                    {
                        studentsGrades.Add(5 * (int)Math.Round(g / 5.0));
                    }
                    else
                    {
                        studentsGrades.Add(g);
                    }
                }
                else 
                {
                    studentsGrades.Add(g); 
                }


            }

            return studentsGrades;

        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = gradingStudents(grades);

            foreach(int num in result)
            {
                Console.WriteLine($"{num}, ");
            }
            

               
          


            //Console.WriteLine(String.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

    }

    


