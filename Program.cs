using System;
using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("please enter your choice: \n1.add number \n2.add number reverse order\n3.insert no\n4.Append\n5.Delete First no\n6.Delete Last\n7.search");
            Console.Write("8.To insert 40 after 30");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    LinkedList linkedList = new LinkedList();
                    linkedList.Add(56);
                    linkedList.Add(30);
                    linkedList.Add(70);
                    linkedList.Display();
                    break;
                case 2:
                    LinkedList linkedList1 = new LinkedList();

                    linkedList1.AddInReverseOrder(70);
                    linkedList1.AddInReverseOrder(30);
                    linkedList1.AddInReverseOrder(56);
                    linkedList1.Display();
                    break;
                case 3:
                    LinkedList linkedList2 = new LinkedList();
                    linkedList2.Add(56);
                    linkedList2.Add(70);
                    linkedList2.InsertNode(2, 12);
                    linkedList2.Display();
                    break;
                case 4:
                    LinkedList linkedList3 = new LinkedList();
                    linkedList3.Append(56);
                    linkedList3.Append(30);
                    linkedList3.Append(70);
                    linkedList3.Display();
                    break;
                case 5:
                    LinkedList linkedList4 = new LinkedList();
                    linkedList4.Add(56);
                    linkedList4.Add(30);
                    linkedList4.Add(70);
                    linkedList4.Pop();
                    linkedList4.Display();
                    break;
                case 6:
                    LinkedList linkedList5 = new LinkedList();
                    linkedList5.Add(56);
                    linkedList5.Add(30);
                    linkedList5.Add(70);
                    linkedList5.PopLast();
                    linkedList5.Display();
                    break;
                case 7:
                    LinkedList linkedList6 = new LinkedList();
                    linkedList6.Add(56);
                    linkedList6.Add(30);
                    linkedList6.Add(70);
                    int a = linkedList6.Search(30);
                    Console.WriteLine("index of 30 is" + a);
                    break;

                case 8:
                    LinkedList LinkedList7 = new LinkedList();
                    LinkedList7.Add(56);
                    LinkedList7.Add(30);
                    LinkedList7.Add(70);
                    LinkedList7.InsertNode(3,40);
                    LinkedList7.Display();

                    break;
            }


        }


    }
}
