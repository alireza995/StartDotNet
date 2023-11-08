namespace StartDotNet;

public static class ValueReaderHelper
{
    public static int ReadInt(string message = "")
    {
        if (!string.IsNullOrWhiteSpace(message))
        {
            Console.WriteLine(message);
        }

        if (int.TryParse(Console.ReadLine() ?? "", out var result))
        {
            return result;
        }

        Console.WriteLine("Invalid number. Retry again");
        throw new Exception();
    }
}