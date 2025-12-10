namespace Learning.Array6.Task;

internal class BootstrapArray6
{
    public void Run()
    {
        int[] arr = new[]
        {
            14, 2, 10, 1, 11, 6, 16, 4, 8, 15, 13,
        };
        int temparray;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temparray = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temparray;
                }
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
