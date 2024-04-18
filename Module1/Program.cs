namespace CSharpModules.Module1
{
    // Після створення класу запустіть програму,
    // яка створює масив,
    // знаходить найбільший елемент та сортує масив.
    // Виведіть початковий масив, знайдений максимум та відсортований масив на консоль.
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = ArrayManipulator.GenerateRandomArray(10, -5, 5);
            int maxElement = ArrayManipulator.FindMax(array);
            int[] sortedArray = ArrayManipulator.SortArray(array);

            Console.WriteLine("Initial array:");
            ArrayManipulator.PrintArray(array);
            Console.WriteLine($"Max element in array: {maxElement}");
            Console.WriteLine("Sorted array:");
            ArrayManipulator.PrintArray(sortedArray);
        }
    }
}
