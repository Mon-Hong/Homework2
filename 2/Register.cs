using System;
using System.Collections.Generic;

public class Register

{
	public string name;
	public string password;
	public string type;
	public string id;
	
	//รับค่าข้อมูลลงทะเบียน
	public Register()
	{
		List<Person> person = new List<Person>();

		Console.Write("Register new Person\n----------------------------------------");

		Console.Write("\nInput Name: ");
		name = Console.ReadLine();

		Console.Write("\nInput Password: ");
		password = Console.ReadLine();
		do
		{
			Console.Write("\nInput User Type 1 = Student, 2 = Employee: ");
			type = Console.ReadLine();
			
		} while (type != "1" && type != "2");

		if (type == "1")
        {
			Console.Write("\nStudent ID: ");
			id = Console.ReadLine();
		}
		if (type == "2")
		{
			Console.Write("\nEmployee ID: ");
			id = Console.ReadLine(); 
		}


	}
	
}
