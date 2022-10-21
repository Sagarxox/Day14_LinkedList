using System.Linq;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {



            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();


            LinkedList linkedList1 = new LinkedList();

            linkedList1.AddInReverseOrder(70);
            linkedList1.AddInReverseOrder(30);
            linkedList1.AddInReverseOrder(56);
            linkedList1.Display();

            LinkedList linkedList2 = new LinkedList();

            linkedList2.Append(56);
            linkedList2.Append(30);
            linkedList2.Append(70);
            linkedList2.Display();




        }
    }
}
