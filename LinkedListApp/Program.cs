using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    class Program
    {
        static List myList = new List();
        static void Main(string[] args)
        {
            bool IsDone = false;

            while (!IsDone)
            {
                Menu();
                MenuSwitch(Convert.ToInt32(Console.ReadLine()));

                Console.ReadLine();
            }

        }


        static void Menu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Create a new List");
            Console.WriteLine("2) Add to Front of List");
            Console.WriteLine("3) Add to Back of List");
            Console.WriteLine("4) Remove from Front of List");
            Console.WriteLine("5) Remove from Back of List");
            Console.WriteLine("6) Print out List");
        }

        static void MenuSwitch(int menuSelect)
        {
            switch (menuSelect)
            {
                case 1:
                    CreateList();
                    break;

                case 2:
                    AddToFront(myList);
                    break;

                case 3:
                    AddToBack(myList);
                    break;

                case 4:
                    myList.RemoveAtFront();
                    break;

                case 5:
                    myList.RemoveFromBack();
                    break;

                case 6:
                    PrintList();
                    break;

                default:
                    break;

            }

        }

        static void CreateList()
        {
            Console.WriteLine("Please input a name for the List");
            var inputName = Console.ReadLine();
            myList = new List(inputName);
            AddToFront(myList);
            
        }

        static void AddToFront(List myList)
        {
            Console.WriteLine("Please input list item");
            var inputItem = Console.ReadLine();
            myList.InsertAtFront(inputItem);
        }

        static void AddToBack(List myList)
        {
            Console.WriteLine("Please input list item");
            var inputItem = Console.ReadLine();
            myList.InsertAtBack(inputItem);
        }



        static void PrintList()
        {
            ListNode currentNode = myList.FirstNode;
            Console.WriteLine(myList.ListName);

            while(currentNode != myList.LastNode)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
            } 
            if (currentNode == myList.LastNode)
                Console.WriteLine(currentNode.Data);
        }



    }
}
