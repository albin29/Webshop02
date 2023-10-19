﻿using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using Microsoft.Win32;

namespace Webshop;

public class Admin
{
    public string username = "admin";
    string adminpassword = "123";

    User user = new User();
    public void AdminMenu()
    {

        Console.WriteLine("Admin Login");

        while (true)
        {
            Console.Write("Please enter your admin password: ");
            string? enteredpassword = Console.ReadLine();

            if (enteredpassword == adminpassword)
            {
                AdminMainMenu();
                break;
            }
            else
            {
                Console.WriteLine("The password was wrong");
                continue;
            }
        }
    }
    public void AdminMainMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Hello, Admin! What would you like to do?");

            Console.WriteLine("1 - to manage products.");
            Console.WriteLine("2 - to manage users.");
            Console.WriteLine("3 - to view order and transaction history.");
            Console.WriteLine("x - to log out.");

            Console.Write("Please navigate by entering the preceding character: ");
            string? menuselection = Console.ReadLine();

            if (menuselection == "1")
            {
                ProductMenu();
                break;
            }
            else if (menuselection == "2")
            {
                UserMenu();
                break;
            }
            else if (menuselection == "3")
            {
                DisplayBuyHistory();
                break;
            }
            else if (menuselection == "x")
            {
                break;
                //AdminMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid entry.");

                Console.WriteLine("Press any key to try again!");
                string? anykey = Console.ReadLine();
                continue;
            }

        }

    }
    public void ProductMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Manage products");
            Console.WriteLine("1 - to add a new product.");
            Console.WriteLine("2 - to edit an existing product.");
            Console.WriteLine("3 - to delete a product.");
            Console.WriteLine("m - to go back to your main menu.");
            Console.WriteLine("x - to log out.");

            Console.Write("Please navigate by entering the proceeding character: ");

            string? menuselection = Console.ReadLine();

            if (menuselection == "1")
            {
                AddProduct();
                break;
            }
            else if (menuselection == "2")
            {
                EditProduct();
                break;
            }

            else if (menuselection == "3")
            {
                DeleteProduct();
                break;
            }


            else if (menuselection == "m")
            {
                AdminMainMenu();
                break;
            }
            else if (menuselection == "x")
            {
                //AdminMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid entry.");

                Console.WriteLine("Press any key to try again!");
                string? anykey = Console.ReadLine();
                continue;
            }
        }
    }
    public void EditProduct()

    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Edit Product");


            string[] lines = File.ReadAllLines("../../../products.csv");

            foreach (string line in lines)
            {
                Console.WriteLine(line); //displays product list
            }


            Console.WriteLine("Which product would you like to edit?");

            Console.Write("Please type in the product name: ");
            string? productToEdit = Console.ReadLine();

            if (productToEdit == "m")
            {
                {
                    Console.WriteLine("Code needed to edit product.");
                }
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid entry.");

                Console.WriteLine("Press any key to try again! Make sure to use correct spelling.");
                string? anykey = Console.ReadLine();
                continue;
            }
        }
    }//some code missing!
    private void AddProduct()
    {
        Console.Clear();
        Console.WriteLine("Add a new product");
        Console.WriteLine("Product List"); //Productlist display
        Console.Write("Please enter a unique product name: ");
        string? productName = Console.ReadLine();

        Console.WriteLine("Please enter a product price in SEK per unit: ");
        string? productPrice = Console.ReadLine();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("You successfully added " + productName + " at " + productPrice + " SEK per unit to your product list.");


            Console.WriteLine("What would you like to do next?");
            Console.WriteLine("1 - to add another product.");
            Console.WriteLine("2 - to view product list.");
            Console.WriteLine("m - to go back to your main menu.");
            Console.WriteLine("x - to log out.");

            Console.Write("Please navigate by entering the preceding character: ");
            string? menuselection = Console.ReadLine();

            if (menuselection == "1")
            {
                AddProduct();
                break;
            }
            if (menuselection == "2")
            {
                Console.WriteLine("Display Productlist."); //code missing display updated product list
                break;
            }
            if (menuselection == "m")
            {
                AdminMainMenu();
                break;
            }
            if (menuselection == "x")
            {
                break; // AdminMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid entry.");
                Console.WriteLine("Press any key to try again!");
                string? anykey = Console.ReadLine();
                continue;
            }

        }
    }

    public void DeleteProduct()

    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Delete Product");


            string[] lines = File.ReadAllLines("../../../products.csv");

            foreach (string line in lines)
            {
                Console.WriteLine(line); //displays product list
            }


            Console.WriteLine("Which product would you like to delete?");
            Console.Write("Please type in the product name: ");
            string? productToEdit = Console.ReadLine();

            if (productToEdit == "M")
            {
                    Console.WriteLine("Code needed to delete product.");   //code needed to delete product!
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid entry.");

                Console.WriteLine("Press any key to try again! Make sure to use correct spelling.");
                string? anykey = Console.ReadLine();
                continue;
            }
        }
    }//some code missing
    public void UserMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Manage users");
            Console.WriteLine("1 - to add a new user.");
            Console.WriteLine("2 - to edit an existing user.");
            Console.WriteLine("3 - to delete a user.");
            Console.WriteLine("M - to go back to your main menu.");
            Console.WriteLine("X - to log out.");
            Console.Write("Please navigate by entering the preceding character: ");
            string? menuselection = Console.ReadLine();

            if (menuselection == "1")
            {
                {
                    AddUser();
                }
                break;
            }

            if (menuselection == "2")
            {
                {
                    EditUser();
                }
                break;
            }

            if (menuselection == "3")
            {
                {
                    DeleteUser();
                }
                break;
            }

            else if (menuselection == "m")
            {
                {
                    AdminMainMenu();
                }
                break;
            }

            else if (menuselection == "x")
            {
                {
                    //AdminMenu();
                    break;
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid entry.");
                Console.WriteLine("Press any key to try again!");
                string? anykey = Console.ReadLine();
                continue;
            }

        }

    }

    public void AddUser()
    {
        user.RegisterUser(); // Accessing the public method

        while (true)
        {

            Console.WriteLine("What would your like to do next?");

            Console.WriteLine("m - to go back to your main menu.");
            Console.WriteLine("x - to log out.");

            Console.Write("Please navigate by entering the preceding character: ");
            string? menuselection = Console.ReadLine();

            if (menuselection == "m")
            {
                {
                    AdminMainMenu();
                }
                break;
            }

            else if (menuselection == "x")
            {
                {
                    //AdminMenu();
                }
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid entry.");

                Console.WriteLine("Press any key to try again!");
                string? anykey = Console.ReadLine();
                continue;
            }
        }
    }
    public void EditUser() //some code missing
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Edit User");


            string[] lines = File.ReadAllLines("../../../users.csv");

            foreach (string line in lines)
            {
                Console.WriteLine(line); //displays user list
            }


            Console.WriteLine("Which user would you like to edit?");

            Console.Write("Please type in the user name: ");
            string? productToEdit = Console.ReadLine();

            if (productToEdit == "M")
            {
                {
                    Console.WriteLine("Code needed to edit user.");
                }
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid entry.");

                Console.WriteLine("Press any key to try again! Make sure to use correct spelling.");
                string? anykey = Console.ReadLine();
                continue;
            }
        }
    }
    public void DeleteUser()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Delete User");


            string[] lines = File.ReadAllLines("../../../users.csv");

            foreach (string line in lines)
            {
                Console.WriteLine(line); //displays user list
            }


            Console.WriteLine("Which user would you like to delete?");

            Console.Write("Please type in the user name: ");
            string? productToEdit = Console.ReadLine();

            if (productToEdit == "M")
            {
                {
                    Console.WriteLine("Code needed to delete user.");   //code needed HERE to delete user!
                }
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid entry.");

                Console.WriteLine("Press any key to try again! Make sure to use correct spelling.");
                string? anykey = Console.ReadLine();
                continue;
            }
        }
    } //some code missing
    public void DisplayBuyHistory()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Order and transaction history");


            string[] lines = File.ReadAllLines("../../../buyHistory.csv");

            foreach (string line in lines)
            {
                Console.WriteLine(line); //displays purchase history
            }


            Console.WriteLine("What would your like to do next?");

            Console.WriteLine("M - to go back to your main menu.");
            Console.WriteLine("X - to log out.");

            Console.Write("Please navigate by entering the preceding character: ");
            string? menuselection = Console.ReadLine();

            if (menuselection == "m")
            {
                {
                    AdminMainMenu();
                }
                break;
            }

            else if (menuselection == "x")
            {
                {
                    break;  //AdminMenu(); 
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid entry.");

                Console.WriteLine("Press any key to try again!");
                string? anykey = Console.ReadLine();
                continue;
            }
        }
    }
}