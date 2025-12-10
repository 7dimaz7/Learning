namespace Learning.Array5.Task;

internal class BootstrapArray5
{
    public void Run()
    {
        int[] arr = new[]
        {
            5, 5, 5,
            8, 2, 7,
            1, 1, 1,
            9, 3, 3,
            6, 6, 6, 6,
            2, 2,
            7, 8, 9,
            10, 12,
            4, 4, 4, 4, 4, 4, 5,
        };
        int numberOfMaxCount = 0;
        int counter = 1;
        int mostRepeatNumber = 0;

        for (int i = 0; i < 30; i++)
        {
            Console.Write(arr[i] + " ");
        }

        for (int i = 0; i < 29; i++)
        {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                }

                if (counter > numberOfMaxCount)
                {
                    mostRepeatNumber = arr[i];
                    numberOfMaxCount = counter;
                }

                if (arr[i] != arr[i + 1])
                {
                    counter = 1;
                }
        }

        Console.Write($"- число {mostRepeatNumber} повторяется {numberOfMaxCount} раза подряд");
    }
}
