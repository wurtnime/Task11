using System.Linq;

namespace Practical11.Tasks
{
    public class Task21 : ITask
    {
        public string Solve(string input)
        {
            double[] array = input.Split(' ').Select(double.Parse).ToArray();
            if (array.Length != 12) throw new ArgumentException("Нужно 12 чисел");
            int minIndex = Array.IndexOf(array, array.Min());
            array[minIndex] *= 3;
            (array[minIndex], array[^1]) = (array[^1], array[minIndex]);
            return $"Новый массив: {string.Join(" ", array)}";
        }
    }
}