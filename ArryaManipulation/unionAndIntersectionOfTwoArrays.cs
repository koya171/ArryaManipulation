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
//    class unionAndIntersectionOfTwoArrays
//    {
//        public static void Main()
//        {
//            int[] arr = new int[] { 5, 2, 3, 2, 1, 3, 4, 6 };
//            int[] arr1 = new int[] { 100, 200, 3, 700, 1, 300, 4, 6 };

//            unionAndIntersectionOfTwoArrays obj = new unionAndIntersectionOfTwoArrays();
//            // obj.FindingtheMissingNumber(arr);
//            obj.unionOfTwoArrays(arr, arr1);
//            // obj.interSectionOfTwoArrays(arr, arr1);


//        }

//        private void interSectionOfTwoArrays(int[] arr, int[] arr1)
//        {
//            HashSet<int> temp = new HashSet<int>();
//            HashSet<int> intersection = new HashSet<int>();

//            for (int i = 0; i < arr.Length; i++)
//            {
//                temp.Add(arr[i]);

//            }

//            for (int i = 0; i < arr1.Length; i++)
//            {
//                if (temp.Contains(arr1[i]))
//                {
//                    intersection.Add(arr1[i]);
//                }
//            }

//            foreach (var item in intersection)
//            {
//                Console.WriteLine(item);
//            }

//        }

//        private void unionOfTwoArrays(int[] arr, int[] arr1)
//        {
//            HashSet<int> finalunion = new HashSet<int>();

//            for (int i = 0; i < arr.Length; i++)
//            {
//                finalunion.Add(arr[i]);

//            }

//            for (int i = 0; i < arr1.Length; i++)
//            {
//                finalunion.Add(arr[i]);
//            }

//            foreach (var item in finalunion)
//            {
//                Console.WriteLine(item + " ");
//            }


//        }


//    }
//}




