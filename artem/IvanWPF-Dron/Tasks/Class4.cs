using System.Linq;

namespace Practical11.Tasks
{
    public class Task4 : ITask
    {
        public string Solve(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            if (array.Length != 10) throw new ArgumentException("Нужно 10 чисел");

            int maxIndex = Array.IndexOf(array, array.Max());
            (array[0], array[maxIndex]) = (array[maxIndex], array[0]);

            return $"Новый массив: {string.Join(" ", array)}";
        }
    }
}