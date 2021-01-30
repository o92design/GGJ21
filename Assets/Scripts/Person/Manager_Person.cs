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
        foreach (Data_Person person in ListOfPersons) {
            Debug.LogFormat("{0} {1} | Born: {2} - Age: {3} - Experience: {4}", person.FirstName, 
                                                                                person.SurName, 
                                                                                person.BirthYear.ToString(), 
                                                                                1887 - person.BirthYear,  
                                                                                person.YearsExperience.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
