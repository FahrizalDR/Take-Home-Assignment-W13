using System;
using System.Linq;
using System.Collections.Generic;

namespace TakeHomeW13
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book"};
            List<string> tambahscroll = new List<string>();
            while (true)
            {
                Console.Write("1. My Sroll list \n2. Add Scroll \n3. Search scroll \n4. Remove scroll \nChoose what to do : ");
                int pilihmenu = Convert.ToInt32(Console.ReadLine());
                if (pilihmenu == 1)
                {
                    Console.WriteLine("\nScroll to learn list : ");
                    for (int i = 0; i < scrolls.Count; i++)
                    {
                        Console.WriteLine($"Scroll {i + 1} : {scrolls[i]}");
                    }
                    Console.WriteLine();
                }
                else if (pilihmenu == 2)
                {
                    Console.Write("How many scroll to add : ");
                    int addscroll = Convert.ToInt32(Console.ReadLine());
                    Console.Write("In what number of queue : ");
                    int queue = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < addscroll; i++)
                    {
                        Console.Write($"Scroll {i + 1} name : ");
                        tambahscroll.Add(Console.ReadLine());
                    }
                    Console.WriteLine();

                    if (queue < 1)
                        queue = 0;
                    else if (queue > scrolls.Count)
                        queue = scrolls.Count;

                    int counter = -1;
                    foreach (var scroll in tambahscroll)
                    {
                        scrolls.Insert(queue + counter, scroll);
                        counter++;
                    }
                    tambahscroll.Clear();
                }
                else if (pilihmenu == 3)
                {
                    Console.Write("Insert scroll name : ");
                    string insertname = Console.ReadLine();
                    if (scrolls.Contains(insertname, StringComparer.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Book found! Queue number : ");
                    }
                    else
                        Console.WriteLine("Book not found!");
                    Console.WriteLine();
                }
                else if (pilihmenu == 4)
                {
                    Console.Write("Remove from list by scroll name ? (y/n)");
                    string pilih = Console.ReadLine();     
                    if (pilih == "y")
                    {
                        Console.Write("Insert scroll name : ");
                        string insertname = Console.ReadLine();
                        if (scrolls.Contains(insertname, StringComparer.OrdinalIgnoreCase))
                        {
                            scrolls.Remove(insertname);
                        }
                        else
                            Console.WriteLine("Book not found!");
                        Console.WriteLine();
                    }
                    else if (pilih == "n")
                    {
                        Console.Write("Input scroll queue : ");
                        int inputqueue = Convert.ToInt32(Console.ReadLine());                        
                        while (inputqueue > scrolls.Count)
                        {
                            Console.Write("Queue not found, insert scroll queue : ");
                            inputqueue = Convert.ToInt32(Console.ReadLine());
                        }
                        scrolls.RemoveAt(inputqueue-1);
                        Console.WriteLine("Book removed!");
                        Console.WriteLine();
                    }
                }
            }           
        }
    }
}
