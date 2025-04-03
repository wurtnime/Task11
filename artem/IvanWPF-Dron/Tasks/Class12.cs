using System.Linq;

namespace Practical11.Tasks
{
    public class Task12 : ITask
    {
        public string Solve(string input)
        {
            double[] array = input.Split(' ').Select(double.Parse).ToArray();
            if (array.Length != 12) throw new ArgumentException("Нужно 12 чисел");
            Array.Sort(array);
            Array.Reverse(array);
            return $"Сумма max и min: {array[0] + array[^1]}";
        }
    }
}