using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Admin
    {
        int uchoice = 0;
        static List<string> stock = new List<string> { "Canvas", "Brushes", "Base", "Paints", "Crayons", "Resin", "Easel", "Pencils", "Artbook", "Colors" };
        static List<int> stckquant = new List<int> { 10, 12, 3, 34, 23, 4, 10, 19, 20, 40 };
        static List<int> stckprice = new List<int> { 200, 50, 350, 80, 75, 110, 500, 30, 75, 30 };

        public Admin() 
        {
        
        }
        public int uselectedopt()//admin interface
        {
            Console.Clear();
            Console.WriteLine("CHO0SE ANY OF THE FOLLOWING OPTIONS: \n1-ADD STOCK \n2-VIEW ADDED ART STOCK \n3-REMOVE PARTICULAR STOCK  \n4-TRACE ANY ITEM FROM THE STOCK\n5-UPDATE STOCK \n6-EXIT");
            Console.Write("Selected option:");
            uchoice = int.Parse(Console.ReadLine());
            while (uchoice != 6)
            {

                if (uchoice == 1)
                {
                    uchoice1();
                    Console.Read();
                }
                else if (uchoice == 2)
                {
                    uchoice2();
                    Console.Read();
                }
                else if (uchoice == 3)
                {
                    uchoice3();
                    Console.Read();
                }
                else if (uchoice == 4)
                {
                    uchoice4();
                    Console.Read();
                }
                else if (uchoice == 5)
                {
                    uchoice5();
                    Console.Read();
                }
                else
                {
                    uchoice6();
                    Console.Read();
                }
            }
            return uchoice;
        }
        int uchoice1()
        {
            Console.WriteLine("ADD STOCK");
            int numofitems;
            Console.Write("Enter the number of items you want to enter:");
            numofitems = int.Parse(Console.ReadLine());
            for (int i = 10; i < numofitems + 10; i++)
            {

                Console.Write( "Enter name of item : ");
                stock[i] = Console.ReadLine();
                Console.Write("Enter quantity: ");
                stckquant[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter price: ");
                stckprice[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("1-Go to main menu \n2-Exit application");
            int op;
            op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                uselectedopt();
            }
            else
            {
                uchoice6();
            }
            return op;
        }

        int uchoice2()
        {
            Console.Clear();
            Console.WriteLine("VIEW ADDED ART STOCK");
            Console.WriteLine("NAME\t\t\t\tQUANTITY\tPRICE(per item)");
            for (int i = 0; stock[i] != "\0"; i++)
            {
                Console.WriteLine( stock[i] + "\t\t\t\t" + stckquant[i] + "\t\t" + stckprice[i] ;
            }
            Console.WriteLine(" ") ;
            Console.WriteLine("1-Go to main menu \n2-Exit application") ;
            int op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                uselectedopt();
            }
            else
            {
                return 0;
            }
            return op;
        }

        int uchoice3()
        {
            Console.Clear() ;
            string todel ;
            int updated=0;
            Console.WriteLine( "REMOVE STOCK");
            Console.Write("Enter the name of the item you want to remove: ");
            todel = Console.ReadLine();
            for (int i = 0; i < 100; i++)
            {
                if (stock[i] == todel)
                {
                    stock[i] = " ";
                    stckprice[i] = 0;
                    stckquant[i] = 0;
                    Console.WriteLine( "The selected item has been deleted.");
                    Console.WriteLine( "1-Go to main menu. \nEnter 0 to Exit applictaion." );
                    updated= int.Parse(Console.ReadLine());
                    if (updated == 1)
                    {
                        uselectedopt();
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            Console.Write("The selected item is not found in available stock.");
            return updated;
        }

        int uchoice4()
        {
            Console.Clear();
            string toupdate;
            int updated =0 ;
            Console.WriteLine( "TRACE ANY ITEM FROM STOCK" );
            Console.Write("Enter the name of the item you want to trace: ");
            toupdate= Console.ReadLine();
            for (int i = 0; i < 100; i++)
            {
                if (stock[i] == toupdate)
                {
                    Console.WriteLine( "The selected item is present." );
                    Console.WriteLine( "1-Go to main menu. \nEnter 0 to Exit applictaion." );
                    updated= int.Parse(Console.ReadLine());
                    if (updated == 1)
                    {
                        uselectedopt();
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            Console.Write("The selected item is not found in available stock.");
            return updated;
        }

        int uchoice5()
        {
            string todel;
            int newprice, newquant;
            int updated =0 ;
            Console.WriteLine("UPDATE STOCK" );
            Console.Write("Enter the name of the item you want to update: ");
            todel= Console.ReadLine();
            Console.Write("Enter the new quantity: ");
            newquant = int.Parse(Console.ReadLine()); ;
            Console.Write("Enter the new price: ");
            newprice= int.Parse(Console.ReadLine());
            for (int i = 0; i < 100; i++)
            {
                if (stock[i] == todel)
                {
                    stckprice[i] = newprice;
                    stckquant[i] = newquant;
                    Console.WriteLine( "The selected item has been updated." )
                    Console.WriteLine("1-Go to main menu. \nEnter 0 to Exit applictaion." );
                    updated = int.Parse(Console.ReadLine()); ;
                    if (updated == 1)
                    {
                        uselectedopt();
                    }
                    else
                    {
                        return 0 ;
                    }
                }
            }
            Console.Write("The selected item is not found in available stock.");
            return updated;
        }

        int uchoice6()
        {
            return 0 ;
        }
    }
}
