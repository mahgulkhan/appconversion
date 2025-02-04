using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        Admin admin;
        User user;

        static void Main(string[] args)
        {
            string path = "D:\\OOP\\App\\credential.txt";
            string[] names = new string[100];
            string[] passwords = new string[100];
            string newuser, newpass;
            Readadmindata(path, names, passwords);
            int result;
            result = Loginscr();
            if (result == 1)
            {
                SignIn(path, names, passwords);
            }
            else if (result == 2)
            {
                Console.Clear();
                Console.Write("Enter New Name (Only alphabets and should not contain space): ");
                newuser = Console.ReadLine();
                Console.Write("Enter New Password (Enter a numeric Password only, 5 digits): ");
                newpass = Console.ReadLine();
                SignUp(path, newuser, newpass);

            }
        }
        static bool Validusername(string usr) //username validity
        {
            if (usr == "")
            {
                return false;
            }
            for (int i = 0; i <= usr.Length; i++)
            {
                if (!(usr[i] == ' '))
                {
                    return true;
                }
            }
            for (int y = 0; y <= usr.Length; y++)
            {
                char check = usr[y];
                if (!((check >= 'A' && check <= 'Z') || (check >= 'a' && check <= 'z')))
                {
                    return false;
                }
            }
            return true;
        }
        static bool Validpass(int key)//password validity
        {
            if (key < 10000 || key > 99999)
            {
                return false;
            }
            return true;
        }
        static int Identity()// confirm identity
        {
            Console.Clear();
            int login;
            Console.WriteLine("                                                       ");
            Console.WriteLine("          ---------------------------------------------");
            Console.WriteLine("          |   SELECT ONE OF THE FOLLOWING OPTIONS:    |");
            Console.WriteLine("          |    1-Admin                                |");
            Console.WriteLine("          |    2-User                                 |");
            Console.WriteLine("          |    3-Exit                                 |");
            Console.WriteLine("          ---------------------------------------------");
            Console.WriteLine("                                                       ");
            Console.Write("                       Entered option:");
            login = int.Parse(Console.ReadLine());
            if (login == 1)
            {
                Admin admin = new Admin();
                admin.uselectedopt();
            }
            if (login == 2)
            {
                User user = new User();
                user.selectedopt();
            }
            if (login == 3)
            {
                return 0;
            }
            return login;
        }
        static int Loginscr()//login function
        {
            Console.Clear();
            int login;
            Console.WriteLine("                                                       ");
            Console.WriteLine("          ---------------------------------------------");
            Console.WriteLine("          |   SELECT ONE OF THE FOLLOWING OPTIONS:    |");
            Console.WriteLine("          |    1-SignIn                               |");
            Console.WriteLine("          |    2-SignUp                               |");
            Console.WriteLine("          |    3-Exit                                 |");
            Console.WriteLine("          ---------------------------------------------");
            Console.WriteLine("                                                       ");
            Console.Write("                     Entered option:");
            login = int.Parse(Console.ReadLine());
            if (login == 3)
            {
                return 0;
            }
            return login;
        }

        static void Readadmindata(string path, string[] names, string[] passwords)//to read data from the admin.txt file
        {
            int idx = 0;
            if (File.Exists(path))
            {
                string record;
                StreamReader data = new StreamReader(path);
                while ((record = data.ReadLine()) != null)
                {
                    names[idx] = Getfield(record, 1);
                    passwords[idx] = Getfield(record, 2);
                    idx += 1;
                }
                data.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }

        static string Getfield(string record, int field)//to separate out fields from text files
        {
            int commacount = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    commacount = commacount + 1;
                }
                else if (commacount == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }

        static void SignIn(string path, string[] names, string[] passwords)//admim's credential
        {
            Console.Clear();
            int o, key = 0;
            string usr;
            Console.Write("Enter your username(Only alphabets and should not contain space): ");
            usr = Console.ReadLine();

            if (Validusername(usr))
            {
                Console.Write("Enter your password (Enter a numeric Password of 5 digits only): ");
                key = int.Parse(Console.ReadLine());
                if (Validpass(key))
                {
                    for (int x = 0; x < 10; x++)
                    {
                        if (usr == names[x] && key == int.Parse(passwords[x]))
                        {
                            Console.WriteLine("");
                            Identity();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong username or password.");
                    Console.WriteLine("Enter 1 to Go back.");
                    Console.Write("Entered option: ");
                    o = int.Parse(Console.ReadLine());
                    if (o == 1)
                    {
                        Identity();
                    }
                    else
                    {
                        Console.WriteLine("Invalid option.");
                    }
                }
            }
            else if (!Validusername(usr))
            {
                Console.WriteLine("Invalid username or password.");
            }
            else if (!Validpass(key))
            {
                Console.WriteLine("Invalid username or password.");
            }
        }
        static void SignUp(string path, string newuser, string newpass)//storing new users along with their password in file
        {
            StreamWriter file = new StreamWriter(path, true);
            if (Validusername(newuser) && Validpass(int.Parse(newpass)))
            {
                file.WriteLine(newuser + "," + newpass);
                file.Close();
                Console.WriteLine("SignedUp Successfully.");
                Console.WriteLine("Press any key to continue.");
                Console.Read();
                Identity();
            }
            else
            {
                Console.WriteLine("Invalid username or password");
                Console.WriteLine("Enter 1 to Go back to login screen.");
                Console.Write("Entered option: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("");
                    Loginscr();
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
        }
    }
}
