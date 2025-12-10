namespace Learning.Array7.Task;

internal class BootstrapArray7
{
    public void Run()
    {
        string text = "которые разделены пробелом в тексте и вывести массив, каждое слово с новой строки.";
        string[] arr = text.Split(' ');
        {
            foreach (string word in arr)
            {
                Console.WriteLine(word);
            }
        }
    }
}
