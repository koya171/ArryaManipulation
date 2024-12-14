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
//    class FindingTheMissingNumber
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = new int[] { 5, 6, 1, 3, 2 };

//            FindingTheMissingNumber obj = new FindingTheMissingNumber();
//            // obj.FindingtheMissingNumber(arr);
//            Console.WriteLine(obj.FindingtheMissingNumbers(arr));


//        }

//        private int FindingtheMissingNumbers(int[] arr)
//        {
//            int n = arr.Length + 1;

//            int sum = n * (n + 1) / 2;

//            for (int i = 0; i < arr.Length; i++)
//            {

//                sum = sum - arr[i];

//            }
//            return sum;
//        }
//    }