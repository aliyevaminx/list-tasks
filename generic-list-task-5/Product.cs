namespace generic_list_task_5
{
    internal class Product
    {
        private string name;
        private int count;
        private double price;

        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public Product(string name, int count, double price)
        {
            Name = name;
            Count = count;
            Price = price;
        }


    }
}
