using System.Collections.Generic;
using System;

public class PersonList
{

    

    private List<Person> personList;
	public PersonList()
	{
		this.personList = new List<Person>();
	}

	public void AddNewPerson(Person person)
	{
		this.personList.Add(person);
	}

    public void FetchPersonsList()
    {
        foreach (Person person in this.personList)
        {
            if (person.GetID() == "1")
            {
                Console.WriteLine("\nName: {0} \nType: Student \n", person.GetName());
            }
            else if (person.GetID() == "2")
            {
                Console.WriteLine("\nName: {0} \nType: Teacher \n", person.GetName());
            }
        }
    }

}
