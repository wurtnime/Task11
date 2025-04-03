using System.Linq;

namespace Practical11.Tasks
{
    public class Task7 : ITask
    {
        public string Solve(string input)
        {
            double[] array = input.Split(' ').Select(double.Parse).ToArray();
            if (array.Length != 15) throw new ArgumentException("Нужно 15 чисел");

            double firstElement = array[0];
            int count = array.Count(n => n > firstElement);

            return $"Количество элементов больше первого: {count}";
        }
    }
}