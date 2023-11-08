namespace StartDotNet;

public static class YourCode
{
    public static string WriteHere()
    {
        /////////////////////شروع کد/////////////////////////
        var firstParam = ValueReaderHelper.ReadInt("Enter first param.");
        var secondParam = ValueReaderHelper.ReadInt("Enter second param.");

        object result = firstParam + secondParam * 2 / 6 + secondParam / 8;
        ////////////////////////پایان کد./////////////////////

        return result.ToString()!;
    }
}