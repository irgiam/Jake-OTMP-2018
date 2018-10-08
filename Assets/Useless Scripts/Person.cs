using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person {

    public string firstName = "";
    public string lastName = "";
    public int age = 0;
    public string address = "";
    public bool isMale = false;
    public bool isMarried =  false;
    public Person spouse;

    public Person()
    {

    }

    public Person (string pFirstName, string pLastName, int pAge, string pAddress, bool pIsMale, bool pIsMarried)
    {
        this.firstName = pFirstName;
        this.lastName = pLastName;
        this.age = pAge;
        this.address = pAddress;
        this.isMale = pIsMale;
        this.isMarried = pIsMarried;
    }

    public bool IsMarriedWith(Person otherPerson)
    {
        if (spouse != null)
        {
            if (otherPerson == this.spouse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}
