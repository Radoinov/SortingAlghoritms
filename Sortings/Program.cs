using System.Diagnostics;

namespace Sortings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine("Bubble sort");
            int[] arr = new int[] { 2, 4, -5, 1, 10, 6 };
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int swapVar = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            sw.Stop();
            Console.WriteLine();
            Console.WriteLine($"vremetu:  {sw} ");
            Stopwatch st = Stopwatch.StartNew();

            Console.WriteLine();
            Console.WriteLine("Selection Sort");
            int[] arr1 = new int[] { 2, 4, -5, 1, 6, 7 };

            for (int i = 0; i < arr1.Length - 1; i++)
            {
                int k = i;
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[j] < arr1[k])
                        k = j;
                }
                int swapVar = arr1[i];
                arr1[i] = arr1[k];
                arr1[k] = swapVar;
            }
            Console.WriteLine(string.Join(" ", arr1));
            st.Stop();
            Console.WriteLine($"vremetu:  {st} ");

            Console.WriteLine();
            Console.WriteLine("Selection Sort");
            int[] arr2 = new int[] { 2, 4, -5, 1, 6, 7 };

            for (int i = 0; i < arr1.Length - 1; i++)
            {
                int k = i;
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[j] < arr1[k])
                        k = j;
                }
                int swapVar = arr1[i];
                arr1[i] = arr1[k];
                arr1[k] = swapVar;
            }
            Console.WriteLine(string.Join(" ", arr1));
            st.Stop();
            Console.WriteLine($"vremetu:  {st} ");
        }
    }
}
