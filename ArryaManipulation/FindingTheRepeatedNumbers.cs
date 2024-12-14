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
//    class FindingTheRepeatedNumber
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = new int[] { 5, 2, 3, 2, 1, 3, 4, 6 };

//            FindingTheRepeatedNumber obj = new FindingTheRepeatedNumber();
//            // obj.FindingtheMissingNumber(arr);
//            Console.WriteLine(FindingTheRepeatedNumbers(arr));


//        }

//        private static int FindingTheRepeatedNumbers(int[] arr)
//        {
//            int firstRepatingValue = -1;

//            HashSet<int> set = new HashSet<int>();
//            for (int i = arr.Length - 1; i >= 0; i--)
//            {
//                if (set.Contains(arr[i]))
//                {
//                    firstRepatingValue = arr[i];
//                }
//                else
//                {
//                    set.Add(arr[i]);
//                }
//            }
//            return firstRepatingValue;
//        }
//    }
//}




