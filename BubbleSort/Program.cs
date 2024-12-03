using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {  //Bubble sorting

       static  List<int> lst = new List<int>();
        static void Main(string[] args)
        {
            LoadList();
            BubbleSort();

            Console.Write("************* Quick Sort *********************");
            //Initializing array
            int[] arr = { 50, 40, 80, 30, 10, 20, 90 };
            Console.Write("Initial Array : ");
            Console.WriteLine(String.Join(" ", arr));
            quicksort(arr, 0, arr.Length - 1);

            Console.Write("***Binary Search:***** ");
            Console.WriteLine("Enter Element");
            string input =  Console.ReadLine();
            int ele = int.Parse(input);
           int res =BinarySearch(arr, 0, arr.Length - 1, ele);

            if(res== -1)
            {
                Console.WriteLine("Element not present ");
            }
            else
            {
                Console.WriteLine("Element present at index " + res);
            }
            Console.ReadKey();
        }

       
       //***************** Binary Search *****************

        private static int BinarySearch(int[] arr, int l, int r , int x)
        {
            if(r>=l)
            {
                int mid = l + (r - l) / 2;
                if(arr[mid] ==x)
                {
                    return mid;
                }

                if (x >= arr[mid])
                   return  BinarySearch(arr, mid + 1, r, x);

                return BinarySearch(arr, l, mid - 1, x);
            }

            return -1;

        }


        public static void quicksort(int[]arr, int i, int j)
        {
            if(i< j)
            {
                int pos = partition(arr,i,j);
                quicksort(arr, i, pos - 1);
                quicksort(arr, pos + 1, j);
            }
        }

        private static int partition(int[]arr,int i,int j)
        {
            int small = i - 1;
            int pivot = arr[j];

            for(int k= i; k < j;k++)
            {
                if (arr[k]<= pivot)
                {
                    small++;
                    Swap(arr, k, small);
                }
            }
            Swap(arr, j, small + 1);
            Console.WriteLine("Pivot = " + arr[small + 1]);
            Console.WriteLine(String.Join(" ", arr));
            return small + 1;
        }

        private static void Swap(int[] arr,int k,int small)
        {
            int temp;
            temp = arr[k];
            arr[k] = arr[small];
            arr[small] = temp;
        }
        public static void LoadList()
        { 
            lst.Add(11);
            lst.Add(32);
            lst.Add(3);
            lst.Add(48);
            lst.Add(95);
        }




        /// <summary>
        /// Bubble Sort
        /// </summary>
        public static void BubbleSort()
        {
            int cnt = lst.Count;
            int temp = 0;
            for (int i = 0; i < cnt - 1; i++)
            {
                for (int j = 0; j < cnt - i - 1; j++)
                {
                    if (lst[j] > lst[j + 1])
                    {
                        temp = lst[j];
                        lst[j] = lst[j + 1];
                        lst[j + 1] = temp;
                    }
                }
            }

            foreach (int n in lst)
            {
                Console.WriteLine(n);
            }
        }
    }
}
