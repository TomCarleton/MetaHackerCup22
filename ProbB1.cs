using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProbB1
{
    internal class ProbB1
    {

        public static void RunProbB1()
        {
            // Read input
            string[] inputString = File.ReadAllLines("D:\\Code\\Meta Hacker Cup\\Qualifying\\Qualifying\\ProbB1Input.txt");

            // Runcode here
            int testCases = Int32.Parse(inputString[0]);    // Read number of test cases
            int readLine = 0;

            for (int i = 1; i <= testCases; i++)
            {
                // Read in integers R & C
                readLine++;
                string[] inputVariables = inputString[readLine].Split(' ');
                int R = Int32.Parse(inputVariables[0]);
                int C = Int32.Parse(inputVariables[1]);
                //readLine = readLine + R + 1;

                // If 0 trees, then possible if left empty
                bool empty = true;
                for (int x = 0; x < R; x++)
                {
                    readLine++;
                    if (inputString[readLine].Contains('^'))
                        empty = false;
                }

                if (empty == true)
                {
                    Console.WriteLine($"Case #{i}: Possible");
                    for (int x = 0; x < R; x++)
                    {
                        for (int y = 0; y < C; y++) // Print empty canvas
                        {
                            Console.Write(".");
                        }
                        Console.Write("\n");
                    }
                    continue;
                }
                // If R or C = 1, then impossible (unless 0 trees)
                if (R == 1 || C == 1)
                {
                    Console.WriteLine($"Case #{i}: Impossible");
                    continue;
                }

                // Otherwise, filling whole array with trees is a valid solution
                Console.WriteLine($"Case #{i}: Possible");
                for (int x = 0; x < R; x++)
                {
                    for (int y = 0; y < C; y++) // Print full canvas of trees
                    {
                        Console.Write("^");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}