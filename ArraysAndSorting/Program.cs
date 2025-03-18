namespace ArraysAndSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] numbers = { 2, 5, 2, 1, 5, 8, 1, -9, 4, 7, 6, 3 };
            SelectionSort(numbers);
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


    }
}
