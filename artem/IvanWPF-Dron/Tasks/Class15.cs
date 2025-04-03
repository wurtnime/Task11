using System.Linq;

namespace Practical11.Tasks
{
    public class Task15 : ITask
    {
        public string Solve(string input)
        {
            double[] array = input.Split(' ').Select(double.Parse).ToArray();
            if (array.Length != 14) throw new ArgumentException("Нужно 14 чисел");
            Array.Sort(array, 0, 7);
            Array.Sort(array, 7, 7);
            Array.Reverse(array, 7, 7);
            return $"Результат: {string.Join(" ", array)}";
        }
    }
}