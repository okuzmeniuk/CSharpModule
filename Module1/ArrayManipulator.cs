namespace CSharpModules.Module1
{
    static class ArrayManipulator
    {
        // Метод GenerateRandomArray(int length, int min, int max),
        // який створює та повертає новий масив заданої довжини з випадковими числами в діапазоні від min до max.
        public static int[] GenerateRandomArray(int length, int min, int max)
        {
            Random random = new Random();
            int[] toReturn = new int[length];

            for (int i = 0; i < length; i++)
            {
                toReturn[i] = random.Next(min, max + 1);
            }

            return toReturn;
        }

        // Метод FindMax(int[] array), який знаходить та повертає найбільший елемент у масиві.
        public static int FindMax(int[] array)
        {
            int maxElement = array[0];

            foreach (int element in array)
            {
                maxElement = element > maxElement ? element : maxElement;
            }

            return maxElement;
        }

        // Метод SortArray(int[] array), який сортує масив у зростаючому порядку.
        public static int[] SortArray(int[] array)
        {
            int[] sortedArray = new int[array.Length];
            array.CopyTo(sortedArray, 0);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                for (int j = 0; j < sortedArray.Length - i - 1; j++)
                {
                    if (sortedArray[j] > sortedArray[j + 1])
                        (sortedArray[j], sortedArray[j + 1]) = (sortedArray[j + 1], sortedArray[j]);
                }
            }

            return sortedArray;
        }

        public static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine('\n');
        }
    }
}
