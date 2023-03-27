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
    //

    class Program
    {
        // Function takes a list of integers and looks for subarr that contains only numbers that the absolute 
        //difference beteen each of the nuber is less or equal 1 
        public static int pickingNumbers(List<int> a)
        {
            int tempVal;
            int tempDiff;

            var tempList = new List<int>();

            for(int i=0; i < a.Count; i++)
            {
                //Always new temp val from list
                tempVal = a[i];
                
                // iterating on each element of the list
                for (int j = 0; j < a.Count; j++)
                {
                    tempDiff = Math.Abs(tempVal - a[j]);

                    if(tempDiff < 1)
                    {
                        tempList.Add(a[j]);       
                    }
                }
                
            }

            foreach (var e in tempList)
            {
                Console.WriteLine(e);
            }
            return tempList.Count;

        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = pickingNumbers(a);

            Console.WriteLine(result);
            


            //Console.WriteLine(String.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

    }

    


