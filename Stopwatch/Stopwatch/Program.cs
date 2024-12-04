using System;

namespace Stopwatch
{
    internal class Program
    {
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Hoán đổi giá trị
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[100000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 1000000); // Sinh số ngẫu nhiên
            }

            // Khởi tạo đối tượng Timer
            watch timer = new watch();

            // Bắt đầu đo thời gian
            timer.Start();

            // Gọi thuật toán sắp xếp chọn
            SelectionSort(arr);

            // Dừng đo thời gian
            timer.Stop();

            // In ra thời gian thực thi
            Console.WriteLine("Thời gian thực thi thuật toán Selection Sort: " + timer.GetElapsedTime() + " ms");
        }
    }
}
