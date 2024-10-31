using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Creature : MonoBehaviour
{
    //public
    public string creatureName;
    public int creaturePower;

    public bool AddSkillBool;
    public bool verHabilidades;

    //private
    private List<Skills> _skills = new List<Skills>();

    private List<Skills> availableSkills = new List<Skills>();

    // Start is called before the first frame update
    void Start()
    {
        availableSkills.Add(new Skills("Fuego", "Lanza una bola de fuego", 80));
        availableSkills.Add(new Skills("Hielo", "Congela al enemigo", 70));
        availableSkills.Add(new Skills("Rayo", "Golpea con un rayo eléctrico", 90));
        availableSkills.Add(new Skills("Curación", "Restaura puntos de salud", 50));
        availableSkills.Add(new Skills("Terremoto", "Provoca un temblor en el terreno que daña a todos los enemigos cercanos.", 100));
        availableSkills.Add(new Skills("Escudo de Hielo", "Crea un escudo de hielo que reduce el daño recibido.", 60));
        availableSkills.Add(new Skills("Flecha Venenosa", "Dispara una flecha que envenena al enemigo, causando daño por segundo.", 75));
        availableSkills.Add(new Skills("Tormenta de Arena", "Crea una tormenta de arena que reduce la visibilidad y causa daño por tiempo.", 80));
        availableSkills.Add(new Skills("Puño de Roca", "Un ataque físico potente que puede aturdir al enemigo.", 90));
        availableSkills.Add(new Skills("Luz Sagrada", "Emite una luz que sana a los aliados y causa daño a los enemigos.", 70));
    }

    // Update is called once per frame
    void Update()
    {
        if (AddSkillBool) 
        { 
            addSkill();

            
        }
        if (verHabilidades)
        {
            ShowSkills();
        }
    }

    public void ShowSkills()
    {
        foreach (Skills skill in _skills)
        {
            print(skill.skillName + " - " + skill.skillDescription + " - " + skill.skillPower);
        }
        verHabilidades = false;
    }

    public void addSkill()
    {
        if (AddSkillBool && availableSkills.Count > 0 && _skills.Count < 4)
        {
            
            int randomIndex = Random.Range(0, availableSkills.Count);

            
            Skills randomSkill = availableSkills[randomIndex];

            
            _skills.Add(randomSkill);

            
            print("Añadida habilidad: " + randomSkill.skillName);
            AddSkillBool = false;

        }
        else
        {
            print("No hay habilidades disponibles para añadir.");
            AddSkillBool = false;

        }
    }
}



