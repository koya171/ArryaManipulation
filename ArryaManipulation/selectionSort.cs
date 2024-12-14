//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;


//namespace ArryaManipulation
//{
//    class selectionSort
//    {
//        public static void Main()
//        {
//            int[] arr = new int[] { 4, 20, 3, 50, 15 };

//            selectionSort obj = new selectionSort();
//            obj.selectionS0rt(arr);
//            obj.print(arr);

//        }

//        private void selectionS0rt(int[] arr)
//        {
//            if (arr.Length == 0 || arr.Length == 1) return;



//            for (int i = 0; i < arr.Length - 1; i++)
//            {
//                int minindex = i;
//                for (int j = i + 1; j < arr.Length; j++)
//                {
//                    if (arr[j] < arr[minindex])
//                    {
//                        minindex = j;
//                    }
//                }

//                if (minindex != i)
//                {
//                    int temp = arr[minindex];
//                    arr[minindex] = arr[i];
//                    arr[i] = temp;
//                }

//            }

//        }

//        private void print(int[] arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.WriteLine(arr[i] + " ");
//            }


//        }
//    }
//}




