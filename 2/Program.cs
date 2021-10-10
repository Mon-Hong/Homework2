using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
			string menu;
			do
			{
				do
				{
					Console.Write("Welcome to Digital Library\n----------------------------------------\n1. Login \n2. Register \n\nSelect Menu: ");
					menu = Console.ReadLine();
					Console.Clear();

				} while (menu != "1" && menu != "2");//ถ้าไม่ใข่1หรือ2ให้กลับไปเลือกใหม่

				if (menu == "1")//ไปหน้าlogin
				{
					Console.Clear();
					
					Login login = new Login();
					
				}

				else if (menu == "2")//ไปหน้าRegister
				{
					Console.Clear();
					PersonList personList = new PersonList();
					Register register = new Register();
				}
				Console.Clear();
			} while (menu == "1" || menu == "2");
		}
    }
}
