using System.Linq;

namespace Practical11.Tasks
{
    public class Task9 : ITask
    {
        public string Solve(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            if (array.Length != 15) throw new ArgumentException("Нужно 15 чисел");

            double average = array.Average();
            double[] newArray = array.Select(n => n - average).ToArray();

            return $"Новый массив: {string.Join(" ", newArray)}";
        }
    }
}