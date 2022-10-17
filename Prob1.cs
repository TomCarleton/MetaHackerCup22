using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Read input
            string[] inputString = File.ReadAllLines("D:\\Code\\Meta Hacker Cup\\Prob1\\Prob1\\Prob1Input.txt");

            // Runcode here
            int testCases = Int32.Parse(inputString[0]);

            for (int i = 1; i <= testCases; i++)
            {

                // Read in integers N & K
                string[] inputVariables = inputString[2 * i - 1].Split(' ');
                int N = Int32.Parse(inputVariables[0]);
                int K = Int32.Parse(inputVariables[1]);

                // Check the cases are big enough for all parts
                if (2*K < N)
                {
                    Console.WriteLine($"Case #{i}: NO");
                    continue;
                }

                // Read in part styles
                string[] inputStylesString = inputString[2 * i].Split(' ');
                int[] inputStyles = Array.ConvertAll(inputStylesString, int.Parse);

                // Check if there are more than 2 of any type
                int[] styleCount = new int[inputStyles.Max()];  // Create blank array to count styles

                for (int x = 0; x < N; x++){
                    for (int y = 1; y <= styleCount.Length; y++)
                    {
                        if (inputStyles[x] == y)    // Count number of each style
                            styleCount[y - 1]++;
                    }
                }

                if (styleCount.Max() > 2)
                {
                    Console.WriteLine($"Case #{i}: NO");
                    continue;
                }



                Console.WriteLine($"Case #{i}: YES");
            }
        }
    }
}
