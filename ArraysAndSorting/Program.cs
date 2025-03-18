namespace ArraysAndSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] numbers = { 2, 5, 2, 1, 5, 8, 1, -9, 4, 7, 6, 3 };
            SelectionSort(numbers);
            InsertionSort(numbers);
            BubbleSort(numbers);
            Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine(string.Join("|", numbers));
            Console.WriteLine(string.Join("|", numbers));
        }

        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minValue = arr[i];
                int minIndex = i;

                for (int j = i+1; j < arr.Length; j++)
                {
                    if (minValue > arr[j])
                    {
                        minValue = arr[j];
                        minIndex = j;
                    }

                }
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }

        }

        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j] < arr[j - 1])
                {
                    (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                    j--;
                }
            }
        }

        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool changes = false;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        changes = true;
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
        }

    }
}
