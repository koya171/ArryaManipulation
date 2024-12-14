//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Net;
//using System.Text;


//namespace ArryaManipulation
//{
//    class Findtriplet
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = new int[] { 1, 4, 45, 6, 10, 8 };
//            int targetsum = 22;


//            //Findtriplet1(arr, targetsum);
//            Findtriplet2(arr, targetsum);





//        }

//        private static void Findtriplet1(int[] arr, int targetsum)
//        {
//            for (int i = 0; i < arr.Length - 2; i++)
//            {
//                for (int j = i + 1; j < arr.Length - 1; j++)
//                {

//                    for (int k = j + 1; k < arr.Length; k++)
//                    {

//                        if (arr[i] + arr[j] + arr[k] == targetsum)
//                        {
//                            Console.WriteLine($" the triplets {arr[i]}, {arr[j]} ,{arr[k]}");
//                        }


//                    }


//                }

//            }
//        }
//        private static void Findtriplet2(int[] arr, int targetsum)
//        {
//            int n = arr.Length;
//            Array.Sort(arr);

//            for (int i = 0; i < n - 1; i++)
//            {

//                int left = i + 1;
//                int right = n - 1;

//                while (left < right)
//                {

//                    int currentsum = arr[i] + arr[left] + arr[right];
//                    if (currentsum == targetsum)
//                    {
//                        Console.WriteLine($"tripletes find:  {arr[i]}, {arr[left]},{arr[right]}");

//                        left++;
//                        right--;

//                    }
//                    else if (currentsum < targetsum)
//                    {
//                        left++;

//                    }
//                    else
//                    {
//                        right--;
//                    }

//                }


//            }

//        }
//    }
//}




