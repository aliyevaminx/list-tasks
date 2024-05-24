public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Birinci parametri daxil edin: ");
        var param1 = Console.ReadLine(); 
        Console.WriteLine("Ikinci parametri daxil edin: ");
        var param2 = Console.ReadLine();

        Swap(ref param1, ref param2);
    }

    public static void Swap<T>(ref T parameter1, ref T parameter2)
    {
        T temp = parameter1;
        parameter1 = parameter2;
        parameter2 = temp;
        Console.WriteLine($"Parameter 1: {parameter1} Parameter 2: {parameter2}");
    }
}