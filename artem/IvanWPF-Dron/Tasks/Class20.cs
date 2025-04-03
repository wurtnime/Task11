using System.Linq;

namespace Practical11.Tasks
{
    public class Task20 : ITask
    {
        public string Solve(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            if (array.Length != 16) throw new ArgumentException("Нужно 16 чисел");
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    array[i] = 0;
                    count++;
                }
            }
            return $"Замен: {count}, Массив: {string.Join(" ", array)}";
        }
    }
}