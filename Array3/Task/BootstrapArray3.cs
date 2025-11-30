namespace ConsoleApp1.Array3;

public class BootstrapArray3
{
    public void Run()
    {
        int[] arr = new int[30]
        {
            66, 38, 34, 5, 76, 
            87, 98, 22, 11, 99,
            44, 76, 33, 87, 15,
            9, 76, 99, 54, 23,
            11, 87, 45, 76, 32,
            99, 14, 87, 55, 56
        };
        int max = arr[0];

        for ( int i = 0; i < arr.Length; i++)
        {
            if (i == 0 && arr[0] > arr[1])
            {
                max = arr[i];
                Console.Write(max + ",");
            }

            if (i != arr.Length - 1 && i != 0 && arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                max = arr[i];
                Console.Write(max + ",");
            }
        
            if (i == arr.Length-1)
            {
                if (arr[i] > arr[i - 1])
                {
                    max = arr[i];
                    Console.Write(max);
                }
            }
        }

    }
}