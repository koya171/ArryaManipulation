//namespace insertionSort
//{
//    class insertionSort
//    {
//        static void main(String[] args)
//        {
//            int[] arr = new int[] { 4, 20, 3, 50, 15 };

//            insertionSort obj = new insertionSort();
//            obj.insertionS0rt(arr);
//            obj.print(arr);

//        }

//        public void insertionS0rt(int[] arr)
//        {

//            if (arr.Length == 0 || arr.Length == 1)
//                return;


//            //we will start with the first element and we wil assume
//            // that this element is already sorted.
//            //skip the 0 element because nothing is there to compare it

//            for (int i = 1; i < arr.Length - 1; i++)
//            {
//                int temp = arr[0];
//                int j;
//                //comare the key with all elements in the sorted array
//                //loop will come out j is done with all iteratin
//                //or temp is greater than j
//                for (j = i - 1; j >= 0 && arr[j] > temp; j--)
//                {
//                    arr[j + 1] = arr[j];
//                }
//                arr[j + 1] = temp;
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




