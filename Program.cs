
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
            Console.WriteLine("After Removal of Last node then linked list is");
            list.RemovaLastNode();
            list.Display();
            Console.ReadKey();
        }
    }
}