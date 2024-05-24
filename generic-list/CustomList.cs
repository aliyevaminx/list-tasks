
namespace generic_list
{
    internal class CustomList<Type>
    {
        private int count;
        private int capacity;
        private Type[] list;
        public int Count { get => count; }
        public int Capacity { get => capacity; }

        public CustomList()
        {
            list = new Type[0];
            capacity = list.Length;
        }

        public void Add(Type listElement)
        {
            if (count == list.Length)
            {
                Array.Resize(ref list, capacity == 0 ? 4 : list.Length * 2);
                capacity = list.Length;
            }

            list[count] = listElement;
            count++;
        }

        public void Remove(Type listElement)
        {
            int index = Array.IndexOf(list, listElement);

            if (index != -1)
            {
                for (int i = index; i < count; i++)
                {
                    list[i] = list[i + 1];
                }
                count--;
            }
        }

        public void Contains(Type listElement)
        {
            int item = Array.IndexOf(list, listElement);

            if (item != -1)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

        }

        public void Any()
        {
            if (count > 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                list[i] = default;
            }

            count = 0;
        }

        public void FirstOrDefault()
        {
            if (count > 0)
                Console.WriteLine(list[0]);
            else
                Console.WriteLine(list[default]);
        }

        public void ElementAtOrDefault(int index)
        {
            if (index >= 0 && index < count)
                Console.WriteLine(list[index]);
            else
                Console.WriteLine(list[default]);

        }

        public void LastOrDefault()
        {
            if (count > 0)
                Console.WriteLine(list[count - 1]);
            else
                Console.WriteLine(list[default]);

        }

        public void GetAll()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i}) {list[i]}");
            }
        }
    }
}
