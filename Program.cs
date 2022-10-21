using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            


        }
    }
}
