namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(2);
            list.Add(1);
            list.Add(3);
            //list.Clear();
            //Console.WriteLine(list.Any());
            //Console.WriteLine(list.FirstorDefault());
            //list.Clear();
            //list.Remove(1);
            //Console.WriteLine(list.Contain(2));
            //list.Remove(3);
            //list.Remove(2);
            //Console.WriteLine(list.Any());
            //Console.WriteLine(list.ElementorDefault(2));
            //Console.WriteLine(list.LastOrDefault());
            list.GetAll();
        }
    }
}
