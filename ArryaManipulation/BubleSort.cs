//namespace BubleSort
//{
//    public class BubleSort
//    {
//        static void Main(string[] args)
//        {
//            // Decalaring an array

//            int[] arr = { 100, 90, 60, 50, 80 };

//            BubleSort obj = new BubleSort();
//            obj.BubbleSort(arr);
//            obj.print(arr);
//        }



//        private void BubbleSort(int[] arr)
//        {

//            if (arr.Length == 0 || arr.Length == 1)
//            {

//                return;
//            }
//            for (int i = 0; i < arr.Length - 1; i++)
//            {
//                for (int j = 0; j < arr.Length - 1 - i; j++)
//                {
//                    if (arr[j] > arr[j + 1])
//                    {
//                        int temp = arr[j];
//                        arr[j] = arr[j + 1];
//                        arr[j + 1] = temp;
//                    }
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