using System;

public class Person
{
	Register register = new Register();

	protected string name;
	protected string password;
	protected string type;
	protected string id;
	public Person()
	{
	

		this.name = register.name;
		this.password = register.password;
		this.type = register.type;
		this.id = register.id;
	}

	public string GetID()
	{
		
		return this.id;
	}
	public string GetName()
    {
		
		return this.name;
    }
}
