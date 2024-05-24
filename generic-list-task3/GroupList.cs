
namespace generic_list_task3
{
    internal class GroupList
    {
        private List<Group> groups = new List<Group>();

        public void AddGroup(Group group)
        {
            if (!groups.Contains(group))
                groups.Add(group);
            else
                Console.WriteLine($"{group.Name} already exists");

        }

        public void GetAllGroups()
        {
            foreach (Group group in groups)
            {
                Console.WriteLine($"Group: {group.Name}");
            }
        }
    }
}
