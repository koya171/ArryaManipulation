
//namespace ArryaManipulation
//{
//    public class AddingAnElement
//    {
//        static void Main(string[] args)
//        {
//            // Decalaring an array

//            int[] arr = { 1, 2, 3, 4, 5 };

//            AddingAnElement addingAnElement = new AddingAnElement();
//            addingAnElement.insertElementInArray(arr, 3, 10);
//            addingAnElement.print(arr);
//            addingAnElement.DeleteElementInArray(arr, 2);
//        }
//        private void insertElementInArray(int[] arr, int postin, int value)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {

//                if (i == postin)
//                {
//                    arr[i] = value;
//                }
//            }
//        }
//        private void print(int[] arr)
//        {

//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.WriteLine(arr[i]);
//            }

//        }
//        private void DeleteElementInArray(int[] arr, int v)
//        {
//            int position = -1;

//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] == v)
//                {
//                    position = i;
//                    break;

//                }
//            }
//            if (position == -1)
//            {
//                Console.WriteLine("element colude ot find");

//            }
//            else
//            {
//                //perfom shift opertaion to delete
//                for (int i = position; i < arr.Length - 1; i++)
//                {
//                    arr[i] = arr[i + 1];

//                }

//                //print
//                for (int i = 0; i < arr.Length - 1; i++)
//                {
//                    Console.WriteLine(arr[i] + " ");
//                }
//            }

//        }
//    }
//}