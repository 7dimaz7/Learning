namespace Learning.Array9.Task;

internal class BootstrapArray9
{
    public void Run()
    {
        char[] arr = { '(', '(', ')', '(', '(', ')', ')', ')' };
        int counterOfFirstBracket = 0;

        int maxDeep = 0;

        for (int i = 0; i < arr.Length; i++)
        {
                if (arr[i] == '(')
                {
                    counterOfFirstBracket++;
                }

                if (arr[i] == ')')
                {
                    counterOfFirstBracket--;
                }

                if (counterOfFirstBracket == -1)
                {
                    Console.Write("Некорректная скобочная последовательность.");
                    break;
                }

                if (counterOfFirstBracket > maxDeep)
                {
                    maxDeep = counterOfFirstBracket;
                }
        }

        if (counterOfFirstBracket != 0)
        {
            Console.Write("Некорректная скобочная последовательность.");
        }
        else
        {
            Console.Write("Корректная скобочная последовательность");
        }

        Console.Write(" " + "Максимум глубины равняется" + " " + maxDeep);
    }
}
