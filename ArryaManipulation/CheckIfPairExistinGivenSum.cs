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
    class CheckIfPairExistinGivenSum
    {
        public static void Main()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int tragetValue = 10;

            if (HasPairWithSum2(arr, tragetValue))
            {
                Console.WriteLine("There is apair with the given Sum.");
            }
            else
            {
                Console.WriteLine("No pair found with the given sum.");
            }
        }

        private static bool HasPairWithSum(int[] arr, int tragetValue)
        {

            if (arr.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == tragetValue)
                    {
                        Console.WriteLine($"pair found:{arr[i]},{arr[j]}");
                        return true;
                    }
                }

            }
            return false;

        }
        private static bool HasPairWithSum1(int[] arr, int tragetValue)
        {
            if (arr.Length == 0)
            {
                return false;
            }

            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int currentSum = arr[left] + arr[right];

                if (currentSum == tragetValue)
                {
                    Console.WriteLine($"pair found (:{arr[left]},{arr[right]})");
                    return true;
                }
                else if (currentSum < currentSum)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return false;

        }

        private static bool HasPairWithSum2(int[] arr, int tragetValue)
        {
            if (arr.Length == 0)
            {
                return false;
            }
            Dictionary<int, int> hasmap = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int complement = tragetValue - arr[i];
                if (hasmap.ContainsKey(complement))
                {
                    int complementIndex = hasmap[complement];
                    Console.WriteLine($"pair find :{arr[complementIndex]},{arr[i]}");
                    return true;
                }
                if (!hasmap.ContainsKey(arr[i]))
                {
                    hasmap.Add(arr[i], i);
                }
            }
            return false;
        }
    }
}



