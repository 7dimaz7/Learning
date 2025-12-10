using System.Globalization;

namespace Learning.Array4.Task;

internal class BootstrapArray4
{
    public void Run()
    {
        int sum = 0;
        int[] arr = Array.Empty<int>();

        while (true)
        {
            string? userInput = Console.ReadLine();
            if (userInput == "exit")
            {
                break;
            }

            if (userInput == "sum")
            {
                Console.WriteLine(sum);
            }

            if (int.TryParse(userInput, NumberStyles.Integer, CultureInfo.InvariantCulture, out int result))
            {
                int[] largerArr = new int[arr.Length + 1];

                for (int i = 0; i < arr.Length; i++)
                {
                    largerArr[i] = arr[i];
                }

                sum += result;
                largerArr[largerArr.Length - 1] = result;
                arr = largerArr;
            }
            else if (userInput != "exit" && userInput != "sum")
            {
                Console.WriteLine("Введите корректное число");
            }

            ShowMatrix(arr);
        }
    }

    private void ShowMatrix(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
