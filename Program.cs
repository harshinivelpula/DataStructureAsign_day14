using DataStructureAsign;

namespace DataStructueAsign
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Search(30);
            list.Display();
            Console.ReadKey();
        }
    }
}