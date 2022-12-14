using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProbA
{
    internal class ProbA
    {

        public static void RunProbA()
        {
            // Read input
            string[] inputString = File.ReadAllLines("D:\\Code\\Meta Hacker Cup\\Qualifying\\Qualifying\\ProbAInput.txt");

            // Runcode here
            int testCases = Int32.Parse(inputString[0]);    // Read number of test cases

            for (int i = 1; i <= testCases; i++)
            {

                // Read in integers N & K
                string[] inputVariables = inputString[2 * i - 1].Split(' ');
                int N = Int32.Parse(inputVariables[0]);
                int K = Int32.Parse(inputVariables[1]);

                // Check the cases are big enough for all parts
                if (2 * K < N)
                {
                    Console.WriteLine($"Case #{i}: NO");
                    continue;
                }

                // Read in part styles
                string[] inputStylesString = inputString[2 * i].Split(' ');
                int[] inputStyles = Array.ConvertAll(inputStylesString, int.Parse);

                // Check if there are more than 2 of any style
                int[] styleCount = new int[inputStyles.Max()];  // Create blank array to count styles

                for (int x = 0; x < N; x++)
                {
                    for (int y = 1; y <= styleCount.Length; y++)
                    {
                        if (inputStyles[x] == y)    // Count number of each style
                            styleCount[y - 1]++;
                    }
                }

                if (styleCount.Max() > 2)   // Check for more than 2 of any style
                {
                    Console.WriteLine($"Case #{i}: NO");
                    continue;
                }

                // Else, solution is possible
                Console.WriteLine($"Case #{i}: YES");
            }
        }
    }
}
