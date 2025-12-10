namespace Learning.Array3.Task;

internal class BootstrapArray3
{
    public void Run()
    {
        int[] arr = new[]
        {
            66, 38, 34, 5, 76,
            87, 98, 22, 11, 99,
            44, 76, 33, 87, 15,
            9, 76, 99, 54, 23,
            11, 87, 45, 76, 32,
            99, 14, 87, 55, 56,
        };

        for (int i = 0; i < arr.Length; i++)
        {
           if (IsLocalMax(arr, i))
               {
                Console.Write(arr[i] + " ");
               }
        }

        bool IsLocalMax(int[] arrayInFunction, int i)
        {
            int n = arrayInFunction.Length;
            if (n == 1)
            {
                return true;
            }

            if (i == 0)
            {
                return arrayInFunction[0] > arrayInFunction[1];
            }

            if (i == n - 1)
            {
                return arrayInFunction[i] > arrayInFunction[i - 1];
            }

            return arrayInFunction[i] > arrayInFunction[i - 1] && arrayInFunction[i] > arrayInFunction[i + 1];
        }
    }
}
