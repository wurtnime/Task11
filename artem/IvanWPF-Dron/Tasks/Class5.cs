using System.Linq;

namespace Practical11.Tasks
{
    public class Task5 : ITask
    {
        public string Solve(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            if (array.Length != 9) throw new ArgumentException("Нужно 9 чисел");

            int maxIndex = Array.IndexOf(array, array.Max());
            int minIndex = Array.IndexOf(array, array.Min());
            (array[maxIndex], array[minIndex]) = (array[minIndex], array[maxIndex]);

            return $"Новый массив: {string.Join(" ", array)}";
        }
    }
}