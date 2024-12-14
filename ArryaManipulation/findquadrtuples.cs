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
//        public static void Main()
//        {
//            int[] arr = new int[] { 1, 0, -1, 0, -2, 2 };
//            int targetsum = 0;

//            List<List<int>> list1 = findQydaruples1(arr, targetsum);
//            List<List<int>> list2 = findQydaruples2(arr, targetsum);
//            foreach (List<int> item in list1)
//            {
//                Console.WriteLine(string.Join(',', item));
//            }
//            Console.WriteLine("-----------------------------------------------------");
//            foreach (List<int> item in list2)
//            {
//                Console.WriteLine(string.Join(',', item));
//            }
//        }

//        private static List<List<int>> findQydaruples1(int[] arr, int targetsum)
//        {
//            List<List<int>> result = new List<List<int>>();

//            int n = arr.Length;
//            Array.Sort(arr);
//            if (arr.Length == 0 || arr.Length <= 4)
//            {
//                return result;
//            }

//            for (int i = 0; i < n - 3; i++)
//            {
//                for (int j = i + 1; j < n - 2; j++)
//                {
//                    for (int k = j + 1; k < n - 1; k++)
//                    {
//                        for (int l = k + 1; l < n; l++)
//                        {
//                            int currentsum = arr[i] + arr[j] + arr[k] + arr[l];

//                            if (currentsum == targetsum)
//                            {
//                                List<int> result1 = new List<int> { arr[i], arr[j], arr[k], arr[l] };
//                                result.Add(result1);
//                            }
//                        }
//                        //avoid duplicate values
//                        while (j < n - 2 && arr[j] == arr[j + 1])
//                        {
//                            j++;
//                        }
//                    }
//                    //avoid duplicate values
//                    while (i < n - 3 && arr[i] == arr[i + 1])
//                    {
//                        i++;
//                    }
//                }

//            }
//            return result;
//        }
//        private static List<List<int>> findQydaruples2(int[] arr, int targetsum)
//        {
//            List<List<int>> result = new List<List<int>>();
//            if (arr.Length == 0 || arr.Length <= 4)
//            {
//                return result;
//            }
//            int n = arr.Length;
//            Array.Sort(arr); ///[-2,-1,0,0,1,2]


//            for (int i = 0; i < n - 3; i++)
//            {
//                for (int j = i + 1; j < n - 2; j++)
//                {
//                    int left = j + 1;
//                    int right = n - 1;

//                    while (left < right)
//                    {
//                        int currentsum = arr[i] + arr[j] + arr[left] + arr[right];
//                        if (currentsum == targetsum)
//                        {
//                            List<int> result1 = new List<int> { arr[i], arr[j], arr[left], arr[right] };
//                            result.Add(result1);
//                            left++;
//                            right--;

//                            //avoid dulicates 
//                            while (left < right && arr[left] == arr[left - 1])
//                            {
//                                left++;
//                            }
//                            //avoid dulicates 
//                            while (left < right && arr[right] == arr[right + 1])
//                            {
//                                right--;
//                            }
//                        }
//                        else if (left < right)
//                        {
//                            left++;
//                        }
//                        else
//                        {
//                            right--;
//                        }
//                    }
//                    //avoid dulicates 

//                    while (j < n - 2 && arr[j] == arr[j + 1])
//                    {
//                        j++;
//                    }
//                }
//                //avoid dulicates 
//                while (i < n - 3 && arr[i] == arr[i + 1])
//                {
//                    i++;
//                }

//            }

//            return result;
//        }
//    }
//}



