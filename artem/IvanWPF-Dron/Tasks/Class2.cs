using System.Linq;

namespace Practical11.Tasks
{
    public class Task2 : ITask
    {
        public string Solve(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            if (array.Length != 12) throw new ArgumentException("Нужно 12 чисел");

            double average = array.Average();
            array[4] = (int)average; // Замена 5-го элемента (индекс 4)

            return $"Новый массив: {string.Join(" ", array)}";
        }
    }
}