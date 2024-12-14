//Binary search

//namespace BinarySearch
//{
//    public class BinarySearch
//    {
//        static void Main(string[] args)
//        {
//            // Decalaring an array

//            int[] arr = { 1, 2, 3, 4, 5 };

//            BinarySearch obj = new BinarySearch();
//          int result=  obj.BinarySearchIndex(arr,4,0,arr.Length-1);
//            if (result == -1)
//            {
//                Console.WriteLine("element not found in the array");
//            }
//            else
//            {
//                Console.WriteLine($"Element found in the position of array: { result}" );

//            }
//        }


//        private int BinarySearchIndex(int[] arr, int value, int start, int end)
//        {
//            // Find length and position of array
//            if (arr.Length == 0 || start > end)
//            {
//                //Not found
//                return -1;
//            }

//            // find the middle position of the array
//            int middle = (start+end)/2;


//            // if the value equals to the midddle index of the array , print the middl eindex of the array
//            if (value ==arr[ middle]) {
//                // found it
//                return middle;
//            }

//            // based on the middle, index move left or right
//            if (value < arr[middle]) { 
//                  return BinarySearchIndex(arr, value, start, middle-1);
                    
//                }
//            else
//            {
//                return BinarySearchIndex(arr, value, middle+1, end);
//            }

//        }
//    }
//}