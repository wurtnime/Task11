using System.Linq;

namespace Practical11.Tasks
{
    public class Task19 : ITask
    {
        public string Solve(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            if (array.Length != 19) throw new ArgumentException("Нужно 19 чисел");
            int sum = 0;
            foreach (int num in array)
            {
                if (num < 0) break;
                sum += num;
            }
            return sum == 0 ? "Нет отрицательных" : $"Сумма: {sum}";
        }
    }
}