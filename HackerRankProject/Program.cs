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
        

        //An arcade game player wants to climb to the top of the leaderboard and track their ranking.
        //The game uses Dense Ranking. Function allows to get the players place in each round
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            //ranked.OrderBy(x => x).ToList(); //Ordering ascending
            int[] places = new int[ranked.Count + 1]; 
            
            //List of player's places
            List<int> playerPlace = new List<int>();

            for(int j=0; j < player.Count; j++)
            {
                //Array.Clear(places,0,places.Length);
                int counter = 1;

                ranked.Add(player[j]);
                var sortedRank = ranked.OrderBy(x => x).Reverse().ToList(); //Descednig order
                
                //sortedRank.ForEach(x => Console.WriteLine(x)); //Debuging

                for (int i = 0; i < sortedRank.Count(); i++)
                {

                    if (!(i == 0) && sortedRank[i] < sortedRank[i - 1])
                    {
                        //Console.WriteLine(i);
                        counter++;
                        places[i] = counter;
                    }

                    places[i] = counter;

                    if (sortedRank[i] == player[j])
                    {
                        playerPlace.Add(counter);
                    }

                }

                ranked.RemoveAll(x => x == player[j]);

                //Debugging
                //foreach (var place in places)
                //{
                //    Console.WriteLine(place);
                //}
                //Console.WriteLine("-----------");
            }

            playerPlace = playerPlace.Distinct().ToList();

            return playerPlace; 
           
      
        }


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
            Func<List<int>, List<int>, List<int>> funExe = climbingLeaderboard;

            int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

            int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

            List<int> result = funExe(ranked, player);
            Console.WriteLine();

            Console.WriteLine(String.Join("\n", result));


            //textWriter.Flush();
            //textWriter.Close();
        }
    }

    }

    


