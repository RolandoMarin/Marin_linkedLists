using System;
using System.Collections.Generic;
using System.Threading;
//Rolando Marin
namespace Marin_linkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = null;

            LinkedList items = new LinkedList();

            string selection;
            
            do
            {
                Console.Clear();

                Console.WriteLine(Menu());

                selection = Console.ReadLine();

                if (selection == "1") 
                {
                    Console.WriteLine("Create Item: ");
                    string newNode = Console.ReadLine();

                    head = items.Add(head, new Node(newNode));
                    Console.WriteLine(newNode + " Added");
                    Console.ReadLine();
                    Console.WriteLine("Press Enter to return");
                }
                else if(selection == "2")
                {
                    Console.WriteLine("Enter Node we are deleting: ");
                    string stringS = Console.ReadLine();

                    Node searchNode = FindNode(head, items, stringS);
                    
                    if(searchNode != null)
                    {
                        head = items.Remove(head, stringS);
                        Console.WriteLine(stringS + " Was removed");

                        
                    }
                    Console.ReadLine();

                }
                else if(selection == "3")
                {
                    Console.WriteLine("What node are we looking for?");
                    string stringS = Console.ReadLine();
                    Node searchNode = FindNode(head, items, stringS);

                    Console.WriteLine(stringS + " was Found");
                    Console.ReadLine();
                    
                }
                else if (selection == "4")
                {
                    Console.WriteLine(items.PrintNodes(head));
                    Console.ReadLine();

                }
                else if (selection == "5")
                {
                    break;
                } 
                




            }while(true);


            static Node FindNode(Node head, LinkedList items, string stringS)
            {
                Node foundNode = items.Contains(head, stringS);
                if (foundNode != null)
                {
                    return foundNode;
                }
                else
                return null;

            }
                    
            }



            static string Menu()
            {
                return "1: Add item\n" +
                       "2: Remove Item \n" +
                       "3. Search  for Item\n" +
                       "4. Print all Nodes \n" +
                       "5. Exit \n" +
                       "Choose One: ";
            }
           

        }

}
