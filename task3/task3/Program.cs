using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 7, 56, 22, 39 };
            
      
            Changed(arr);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static void Changed(int[] arr) 
        { int min = 0; int max = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[min])
                {
                    min = arr[i];
                }
                if (arr[i] > arr[max])
                {
                    max = arr[i];
                }
            }
            arr[max] = arr[min] + arr[max];
            arr[min] = arr[max] - arr[min];
            arr[max] = arr[max] - arr[min];

            return;
        }
     }


}
        

      
