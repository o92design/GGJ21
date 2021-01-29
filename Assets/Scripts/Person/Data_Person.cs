using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum SEX {
    FEMALE,
    MALE
}
public enum PARTNER {
    WIFE,
    SECRET_LOVER,
    NONE
}

public struct Data_Person
{
    public string FirstName;
    public string SurName;
    public SEX Sex;
    public PARTNER Partner;
    public int BirthYear;
    public int BirthMonth;
    public int BirthDay; // !! NoOne is Allowed to be born after 28 !!
    public float Morale;
    public float Panic;
    public float YearsExperience;
}
