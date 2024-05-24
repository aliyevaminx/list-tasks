using generic_list_task3;

public static class Program
{
    public static void Main(string[] args)
    {
        GroupList groupsList = new GroupList();

        groupsList.AddGroup(new Group("Group1"));
        groupsList.AddGroup(new Group("Group2"));
        groupsList.AddGroup(new Group("Group3"));
        groupsList.AddGroup(new Group("Group4"));
        groupsList.GetAllGroups();
    }
}