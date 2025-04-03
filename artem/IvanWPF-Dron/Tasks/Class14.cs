using System.Linq;

namespace Practical11.Tasks
{
    public class Task14 : ITask
    {
        public string Solve(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            if (array.Length != 17) throw new ArgumentException("Нужно 17 чисел");
            int sum = array.Where(n => n % 2 != 0).Sum();
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 3 == 0) array[i] = sum;
            return $"Новый массив: {string.Join(" ", array)}";
        }
    }
}