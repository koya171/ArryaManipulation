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
//    class segrigateEvenAndOdds
//    {
//        public static void Main()
//        {
//            int[] arr = new int[] { 2, 4, 1, 6, 3, 8, 7, 3 };
//            //segreagate odd and even numbers
//            segrigateEvenAndOdd(arr);
//            Console.WriteLine("Segregated Array:" + string.Join(",", arr));


//        }

//        private static void segrigateEvenAndOdd(int[] arr)
//        {
//            int left = 0;
//            int right = arr.Length - 1;
//            while (left < right)
//            {

//                //move left pointer to find an odd number
//                while (arr[left] % 2 == 0 && left < right)
//                {
//                    left++;
//                }

//                //move right pointer to find an even number
//                while (arr[right] % 2 != 0 && left < right)
//                {
//                    right--;
//                }

//                //swap odd and even numbers
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



