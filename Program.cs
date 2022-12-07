using DataStructureAsign;

namespace DataStructueAsign
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList objLinkedList = new LinkedList();
            objLinkedList.Add(56);
            objLinkedList.Add(30);
            objLinkedList.Add(40);
            objLinkedList.Add(70);
            objLinkedList.Display();
            objLinkedList.sortList();
            objLinkedList.Display();


            Console.ReadLine();
        }
    }
}