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
//    class segrigateZeroAndones
//    {
//        public static void Main()
//        {
//            int[] arr = new int[] { 0, 0, 1, 0, 1, 0, 0, 1, 1, 1 };
//            //segreagate odd and even numbers
//            segrigateZeroAndone(arr);
//            Console.WriteLine("Segregated Array:" + string.Join(",", arr));
//        }

//        private static void segrigateZeroAndone(int[] arr)
//        {
//            int left = 0;
//            int right = arr.Length - 1;
//            while (left < right)
//            {
//                //move left pointer to find an odd number
//                while (arr[left] == 0 && left < right)
//                {
//                    left++;
//                }
//                //move right pointer to find an even number
//                while (arr[right] == 1 && left < right)
//                {
//                    right--;
//                }
//                //swap 0 and 1 numbers
//                if (left < right)
//                {
//                    int temp = arr[left];
//                    arr[left] = arr[right];
//                    arr[right] = temp;
//                    left++;
//                    right--;
//                }
//            }
//        }
//    }
//}



