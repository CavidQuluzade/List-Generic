using System.Text.RegularExpressions;

namespace TaskGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();

            
            AddGroup(groups, new Group("Group 1"));
            AddGroup(groups, new Group("Group 2"));
            AddGroup(groups, new Group("Group 2"));
            foreach (var group in groups)
            {
                Console.WriteLine(group.Name);
            }
            static void AddGroup(List<Group> groups, Group newGroup)
            {   
                foreach (var group in groups)
                {
                    if (group.Name == newGroup.Name)
                    {
                        Console.WriteLine($"This Group already exists");
                        return;
                    }
                }
                groups.Add(newGroup);
            }
        }
    }
}
