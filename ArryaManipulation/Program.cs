using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;


namespace ArryaManipulation
{
    class TwoSumArrays
    {
        public static void Main()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 100;
            int[] result = TwoSumArray(nums, target);
            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        }
 
          private static int[] TwoSumArray(int[] arr, int target)
        {
            // Dictionary to store numbers and their indices
            Dictionary<int, int> hasmap = new Dictionary<int, int>();

            // Iterate through the array
            for (int i = 0; i < arr.Length; i++)
            {
                // Calculate the complement
                int complement = target - arr[i];
                // Check if the complement exists in the dictionary
                if (hasmap.ContainsKey(complement))
                {
                    // Return the indices of the two numbers
                    return new int[] { hasmap[complement], i };
                }
                if (!hasmap.ContainsKey(complement))
                {
                    // Add the current number and its index to the dictionary
                    hasmap.Add(arr[i], i);
                }
               
            }

            // No solution found (though guaranteed by the problem description)
            throw new ArgumentException("No solution found");
        }

      
    }
}



