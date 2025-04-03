using System.Linq;

namespace Practical11.Tasks
{
    public class Task22 : ITask
    {
        public string Solve(string input)
        {
            double[] array = input.Split(' ').Select(double.Parse).ToArray();
            if (array.Length != 15) throw new ArgumentException("Нужно 15 чисел");
            Array.Reverse(array);
            return $"Результат: {string.Join(" ", array)}";
        }
    }
}