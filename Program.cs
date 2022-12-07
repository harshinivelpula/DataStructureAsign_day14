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
            Console.WriteLine("after deleting of first element,linked list is");
            list.DeleteFirstNode();
            list.Display();
            Console.ReadKey();
        }
    }
}