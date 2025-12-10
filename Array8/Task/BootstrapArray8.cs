using System.Globalization;

namespace Learning.Array8.Task;

internal class BootstrapArray8
{
    public void Run()
    {
        int userInput = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
        int tempNumber;
        int[] arr = new[]
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
        };
        for (int i = 0; i < userInput; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                tempNumber = arr[j + 1];
                arr[j + 1] = arr[j];
                arr[j] = tempNumber;
            }
        }

        foreach (var item in arr)
           {
            Console.Write(item + " ");
           }
    }
}
