using generic_list;

public static class Program
{
    public static void Main(string[] args)
    {
        CustomList<int> numbers = new CustomList<int>();

        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(6);
        numbers.GetAll();
        Console.WriteLine();
        Console.WriteLine();
        numbers.Remove(6);
        numbers.GetAll();
        numbers.Contains(14);
        numbers.Any();
        Console.WriteLine();
        numbers.Remove(1);
        numbers.Remove(2);
        numbers.Remove(3);
        numbers.Remove(4);
        numbers.Remove(5);
        numbers.Any();
        Console.WriteLine();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);
        numbers.GetAll();
        //numbers.Clear();
        Console.WriteLine();
        numbers.GetAll();
        numbers.FirstOrDefault();
        numbers.ElementAtOrDefault(1);

    }
}