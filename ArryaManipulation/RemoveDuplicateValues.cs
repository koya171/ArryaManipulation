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
//    class RemoveDuplicateVlauesFormArray
//    {
//        public static void Main(string[] args)
//        {

//            int[] arr = { 1, 2, 2, 3, 3, 4, 5, 5 };

//            RemoveDuplicateVlauesFormArray obj = new RemoveDuplicateVlauesFormArray();

//            obj.RemoveDuplicateValues(arr);

//        }

//        private int[] RemoveDuplicateValues(int[] sortedarray)
//        {
//            int n = sortedarray.Length;

//            if (n <= 1)
//            {
//                return sortedarray;
//            }

//            int index = 0;
//            for (int i = 0; i < n - 1; i++)
//            {

//                if (sortedarray[i] != sortedarray[i + 1])
//                {
//                    sortedarray[index++] = sortedarray[i];

//                }
//            }
//            //copy the last element
//            sortedarray[index++] = sortedarray[n - 1];

//            // resize aray exact length;

//            Array.Resize(ref sortedarray, index);
//            return sortedarray;
//        }
//    }
//}




