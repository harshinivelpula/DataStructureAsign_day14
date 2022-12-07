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
            list.Add(40);
            list.Add(70);
            list.Display();
            Console.Write("enter element to delete");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter previous element of that element to delete");
            int b = Convert.ToInt32(Console.ReadLine());
            list.Delete(b, a);
            list.Display();
            list.size();
        }
    }
}