using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListPracticeFamilyMembers : MonoBehaviour {
    //array
    string[] familyMembers = new string[]{"John", "Amanda", "Chris", "Amber"};
    //List<T>
    public List<string> familyMembers2 = new List<string>();
    //ArrayList
    public ArrayList inventory = new ArrayList();
    //DIctionaries or hashtable
    public Hashtable personalDetail = new Hashtable();

    // Use this for initialization
    void Start () {

        familyMembers2.Add("Greg");
        familyMembers2.Add("Grig");
        familyMembers2.Add("Grog");
        familyMembers2.Add("Grag");

        inventory.Add(128);
        inventory.Add(true);
        inventory.Add("Mike");

        personalDetail.Add("firstName", "Irgi");
        personalDetail.Add("lastName", "Abdul");
        personalDetail.Add("age", 22);
        personalDetail.Add("isMarried", false);

        //Debug.Log(familyMembers[0]);
        //string thirdFamilyMembers2 = familyMembers2[2];
        //Debug.Log(thirdFamilyMembers2);
        //Debug.Log(familyMembers2.Count);
        //Debug.Log(inventory[1].GetType());
        Debug.Log((string)personalDetail["firstName"]);
        Debug.Log((bool)personalDetail["isMarried"]);
        if (personalDetail.Contains("firstName"))
        {
            Debug.Log((string)personalDetail["firstName"]);
        }
        else
        {
            Debug.Log("there is no personalDetail with 'FirstName' key");
        }

        //foreach loop 
        /* foreach (string familyMember in familyMembers2)
        {
            Debug.Log(familyMember);
        } */

        //for loop
        for (int i=0; i<familyMembers2.Count; i++)
        {
            Debug.Log(familyMembers2[i]);
        }

        //while loops
        /*int i = 0;
        while (i < familyMembers2.Count)
        {
            Debug.Log(familyMembers2[i]);
            i++;
        }*/

        int grogIndex = -1;
        for (int i = 0; i < familyMembers2.Count; i++)
        {
            if (familyMembers2[i] == "Grog")
            {
                grogIndex = i;
                break;
            }
        }

        if (grogIndex == -1)
        {
            Debug.Log("Grog is not found");
        }
        else
        {
            Debug.Log("Grog is found at index " + grogIndex);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
