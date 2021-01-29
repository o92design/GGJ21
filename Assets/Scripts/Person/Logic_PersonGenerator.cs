using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic_PersonGenerator
{
    public Data_Person Generate()
    {
        Data_Person returnPerson = new Data_Person();
        returnPerson.FirstName = "Test";
        returnPerson.SurName = "Testsson";
        return returnPerson;
    }
}
