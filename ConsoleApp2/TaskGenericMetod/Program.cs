namespace TaskGenericMetod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> list = new GenericList<string>();
            
            list.Swap("Javid", "Quluzade");
        }
    }
}
