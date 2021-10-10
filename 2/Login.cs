using System;
using System.Collections.Generic;

public class Login
{
	public string namelog;
	public string passwordlog;
	public Login()
	{

		List<PersonList> person = new List<PersonList>();
		PersonList personList = new PersonList();

		personList.FetchPersonsList();
		
		Console.Write("Login Screen\n----------------------------------------");

		Console.Write("\nInput Name: ");
		namelog = Console.ReadLine();

		Console.Write("\nInput Password: ");
		passwordlog = Console.ReadLine();
		

	}

}
