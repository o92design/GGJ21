using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Person : MonoBehaviour
{

    public Logic_PersonGenerator PersonGenerator = new Logic_PersonGenerator();
    public List<Data_Person> ListOfPersons = new List<Data_Person>();
    void Start()
    {
        ListOfPersons.Add(PersonGenerator.Generate());
        ListOfPersons.Add(PersonGenerator.Generate());
        ListOfPersons.Add(PersonGenerator.Generate());
        ListOfPersons.Add(PersonGenerator.Generate());
        Debug.Log(ListOfPersons[0].FirstName + " " + ListOfPersons[0].SurName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
