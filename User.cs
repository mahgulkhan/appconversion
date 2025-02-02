using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App
{
    internal class User
    {
        int choice = 0;
        static List<string> stock = new List<string> { "Canvas", "Brushes", "Base", "Paints", "Crayons", "Resin", "Easel", "Pencils", "Artbook", "Colors" };
        static List<int> stckquant = new List<int> { 10, 12, 3, 34, 23, 4, 10, 19, 20, 40 };
        static List<int> stckprice = new List<int> { 200, 50, 350, 80, 75, 110, 500, 30, 75, 30 };

        public User()
        {

        }
        public int selectedopt()//user interphase
        {
            Console.Clear();
            Console.WriteLine ( "CHO0SE ANY OF THE FOLLOWING OPTIONS: \n 1-APPLY FOR MEMBERSHIP CARD \n 2-VIEW AVAILABLE ART STOCK \n 3-ORDER PAINTING \n 4-BUY ART SUPPLIES  \n 5-RATE OUR SERVICE \n 6-EXIT" );
            Console.Write("Selected option:");
            choice = int.Parse(Console.ReadLine());
            //User Functionalities
            while (choice != 6)
            {

                if (choice == 1)
                {
                    choice1();
                    Console.Read();
                }
                else if (choice == 2)
                {
                    choice2();
                    Console.Read();
                }
                else if (choice == 3)
                {
                    choice3();
                    Console.Read();
                }
                else if (choice == 4)
                {
                    choice4();
                    Console.Read();
                }
                else if (choice == 5)
                {
                    choice5();
                    Console.Read();
                }
                else
                {
                    choice6();
                    Console.Read();
                }
            }

            return choice;
        }

        int choice1()
        {
            Console.Clear ();
            int apply;
            Console.WriteLine("APPLY FOR MEMBERSHIP CARD");
            Console.WriteLine("Press 1 to apply");
            Console.WriteLine("Press 0 to go back to main menu.");
            Console.WriteLine("Press 2 to Exit application.");
            Console.Write("Entered option: ");
            apply = int.Parse(Console.ReadLine());
            if (apply == 1)
            {
                Console.WriteLine("Thank you for applying for our membership card. You will receive it soon :)");
                Console.WriteLine("Press any key to go to the main menu.");
                Thread.Sleep(200);
                Console.Read();
                selectedopt();
            }
            else if (apply == 0)
            {
                selectedopt();
            }
            else
            {
                return 0;
            }
            return apply;
        }

        int choice2()
        {
            Console.Clear();
            int op;
            Console.WriteLine("VIEW AVAILABLE ART STOCK:");
            Console.WriteLine("NAME\t\t\t\tQUANTITY\tPRICE(per item)");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(stock[i] + "\t\t\t\t" + stckquant[i] + "\t\t" + stckprice[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("1-Go to main menu \n2-Exit application");
            op= int.Parse(Console.ReadLine());
            if (op == 1)
            {
                selectedopt();
            }
            else
            {
                return 0;
            }
            return op;
        }

        int choice3()
        {
            Console.Clear();
            string title, add, method;
            Console.WriteLine("BUY ART-WORK.");
            Console.Write("Enter painting title(must be a single title): ");
            title = Console.ReadLine();
            Console.Write( "Enter adress: ");
            add = Console.ReadLine();
            Console.Write("Enter payment method :");
            method = Console.ReadLine();
            Console.WriteLine("Your order has been placed succesfully!");
            int option;
            Console.WriteLine("1-Go to main menu \n2-Exit application");
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                selectedopt();
            }
            else
            {
                return 0;
            }
            return option;
        }

        int choice4()
        {
            Console.Clear();
            string quant, title, add, method;
            Console.WriteLine("BUY ART SUPPLIES");
            Console.Write("Enter Product name:");
            title = Console.ReadLine();
            Console.Write("Enter quantity: ");
            quant = Console.ReadLine();
            Console.Write("Enter adress: ");
            add = Console.ReadLine();
            Console.Write("Enter payment method :");
            method = Console.ReadLine();
            Console.WriteLine("Your order has been placed succesfully!");
            int option;
            Console.WriteLine("1-Go to main menu \n2-Exit application");
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                selectedopt();
            }
            else
            {
                return 0;
            }
            return option;
        }

        public int choice5()
        {
            Console.Clear();
            int star, back=0;
            Console.WriteLine("RATE OUR SERVICE");
            Console.WriteLine("Press 0 to go to menu or to exit application.");
            Console.Write("On a scale of 1-5, how much satisfaied are you with our service(Enter 1-5 stars *): ");
            star = int.Parse(Console.ReadLine());
            if (star >= 1 && star <= 5)
            {
                Console.WriteLine("Thank you for your opinion, we will try to further improve our service.");
                return 0;
            }
            else if (star == 0)
            {
                Console.WriteLine("1-Go to main menu \n2-Exit application");
                back = int.Parse(Console.ReadLine());
                if (back == 1)
                {
                    selectedopt();
                }
                else if (back == 2)
                {
                    return 0;
                }
            }
            return back;
        }
        int choice6()
        {
            return 0;
        }
    }
}
