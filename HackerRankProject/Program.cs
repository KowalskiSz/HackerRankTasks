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
        //Function gets two lists of prices and overall budget and compers the values
        //Returns either max value or if the value exceeds the available budget - it returns -1 
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int maxValue = 0;
            int curVal;
            int tempVal; 

            for(int i=0; i < keyboards.Length; i++)
            {
                curVal = keyboards[i];

               

                for(int j=0; j < drives.Length; j++)
                {
                    tempVal = curVal + drives[j];

                    

                    if (tempVal > maxValue && tempVal < b)
                    {
                        maxValue = tempVal;
                        
                    }

                }
            }

            if(maxValue != 0)
            {
                return maxValue;
            }
            
            return -1; 


            
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

            int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

            List<int> result = climbingLeaderboard(ranked, player);

            Console.WriteLine(String.Join("\n", result));


            //textWriter.Flush();
            //textWriter.Close();
        }
    }

    }

    


