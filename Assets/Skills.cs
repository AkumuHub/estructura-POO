using UnityEngine;
using System.Collections.Generic;

// Clase que representa las habilidades
[System.Serializable] // Esto permite que Unity muestre la clase en el Inspector
public class Skills
{
    public string skillName;
    public string skillDescription;
    public int skillPower;

    public Skills(string name, string description, int power)
    {
        this.skillName = name;
        this.skillDescription = description;
        this.skillPower = power;
    }
}
