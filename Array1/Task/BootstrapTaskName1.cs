namespace ConsoleApp1.Array1;

public class BootstrapArray1
{
    public void Run()
    {
        int [,] array = new int [4,4] { {1,2,3,4}, {2, 3 , 4 , 5 }, { 3, 4 , 5, 6, } , { 4, 5, 6 ,7 } };
        int sum = 0;
        int product = 1;
            
        for (int i = 0; i < array.GetLength(0); i++)

        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == 0)
                {
                    sum = sum + array[0, j];
                }
                if (i == 1)
                {
                    product *= array[1, j];

                }
                Console.Write(array[i,j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(sum + " " + "Сумма");
        Console.WriteLine(product + " " + "Произведение");

        
    }
}