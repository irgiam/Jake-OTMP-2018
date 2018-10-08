using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family : MonoBehaviour {

    public Person father;
    public Person mother;
    public Person son;
	// Use this for initialization
	void Start () {
        father = new Person();
        father.firstName = "Johny";
        father.lastName = "Boi";
        father.age = 35;
        father.address = "New York";
        father.isMale = true;
        father.isMarried = true;
        
        mother = new Person();
        mother.firstName = "Kate";
        mother.lastName = "Katy";
        mother.age = 29;
        mother.address = "New York";
        mother.isMale = false;
        mother.isMarried = true;

        father.spouse = mother;
        mother.spouse = father;

        son = new Person("Simba", "Lion", 10, "New York", true, false);
        

        if (father.IsMarriedWith(mother))
        {
            Debug.Log(father.firstName + " and " + mother.firstName + " is married, and has a handsome son named " + son.firstName);
        }
        else
        {
            Debug.Log("they're not even married");
        }
        
	}
	
}
