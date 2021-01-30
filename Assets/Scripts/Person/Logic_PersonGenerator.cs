using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArrayOfNames {
    public string[] FirstNames = {"Oscar", "Jakob", "Jens", "Piotr", "Svein", "Bjørn", "Bjarne", "Eivind"};
    public string[] SurNames = {"Aanonsen", "Berrefjord", "Ask", "Bøhn", "Gjertsen"};
}

public class Logic_PersonGenerator
{
    private ArrayOfNames names = new ArrayOfNames();
    
    public Data_Person Generate()
    {
        Data_Person returnPerson = new Data_Person();
        returnPerson.BirthDay = Random.Range(1, 29);
        returnPerson.BirthMonth = Random.Range(1, 13);
        returnPerson.BirthYear = Random.Range(1820, 1875); // Game is set 1887
        returnPerson.Sex = SEX.MALE;
        returnPerson.YearsExperience = Random.Range(0, (1887 - returnPerson.BirthYear) - 11);
        returnPerson.FirstName = names.FirstNames[Random.Range(0, names.FirstNames.Length)];
        returnPerson.SurName = names.SurNames[Random.Range(0, names.SurNames.Length)];
        return returnPerson;
    }
}
