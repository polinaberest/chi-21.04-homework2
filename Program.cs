
using homework2;
internal class Program
{
    //2nd variant - the first one in another branch
    private static void Main(string[] args)
    {
        int taskNum;
        Console.Write("Choose the task number (1-4): ");

        while (!int.TryParse(Console.ReadLine(), out taskNum) || taskNum < 1 || taskNum > 4)
        {
            Console.Write("Choose the task number (1-4): ");
        }

        switch (taskNum)
        {
            case 1:
                Task1.Run();
                break;
            case 2:
                Task2.Run();
                break;
            case 3:
                Task3.Run(100);
                break;
            case 4:
                Task4.Run(40);
                break;
        }
    }
}