using generic_list_task_5;

public static class Program
{
    public static void Main(string[] args)
    {
        Shop shop = new Shop();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Sell Product");
            Console.WriteLine("3. Show Products");
            Console.WriteLine("4. Show Total Income");
            Console.WriteLine("5. Exit");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("Choose product type: Tea(T) / Coffee (C)");
                    string type = Console.ReadLine();
                    Console.WriteLine("Enter product name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter product price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter product count: ");
                    int count = Convert.ToInt32(Console.ReadLine());

                   
                    while (true)
                    {
                        if (type == "T")
                        {
                            shop.AddProduct(new Tea(name, count, price));
                            break;
                        }
                        else if (type == "C")
                        {
                            shop.AddProduct(new Coffee(name, count, price));
                            break;
                        }
                        else
                            Console.WriteLine("Choose correct type");
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Enter product name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter product count: ");
                    count = Convert.ToInt32(Console.ReadLine());

                    shop.SellProduct(name, count);
                    break;
                case "3":
                    Console.WriteLine();
                    shop.DisplayAvailableProducts();
                    break;
                case "4":
                    Console.WriteLine();
                    shop.ShowIncome();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Choose right option");
                    break;
            }
        }

    }
}