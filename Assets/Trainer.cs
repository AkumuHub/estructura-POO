using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainer : MonoBehaviour
{
    //public
    public string trainerName;
    public  Creature creature;


    public bool entrenar;
    //private


    // Start is called before the first frame update
    void Start()
    {
        entrenar = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (entrenar)
        {
            Train();
        }
    }

    public void Train()
    {
        if (creature.creaturePower < 100) 
        {
            creature.creaturePower += 10;
            entrenar = false;
            if (creature.creaturePower > 100)
            {
                creature.creaturePower = 100;
            }
            print(trainerName + " entrenó a " + creature.creatureName + ", ahora su poder es: " + creature.creaturePower);
        }  
        else
        {
            print(creature.creatureName + " ya tiene su poder al maximo");
            entrenar = false;
        }
    }
    


}
