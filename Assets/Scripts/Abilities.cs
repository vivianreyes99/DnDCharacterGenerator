using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Abilities : MonoBehaviour
{

	public GameObject Strength;
	public GameObject Dexterity;
	public GameObject Constitution;
	public GameObject Intelligence;
	public GameObject Wisdom;
	public GameObject Charisma;

	public List<string> abilities;
    List<string> abilities_output = new List<string>();
    public WUI_Component controller;


    void Start()
	{
		abilities = new List<string>();
        abilities.Add("Strength");
        abilities.Add("Dexterity");
        abilities.Add("Constitution");
        abilities.Add("Intelligence");
        abilities.Add("Wisdom");
        abilities.Add("Charisma");
        controller = GameObject.Find("UI_Controller").GetComponent<WUI_Component>();
         
    }

	private int roll()
	{
		List<int> rolls = new List<int>();

		for (int i = 0; i < 5; i++)
		{
			rolls.Add(Random.Range(1, 6));
		}

		rolls.Sort();
		int one = rolls[rolls.Count - 1];
		int two = rolls[rolls.Count - 2];
		int three = rolls[rolls.Count - 3];

		return one + two + three;
	}

 

    public void click_dice()
    { 
        int dice_roll = roll();
        string mod = ", Mod = 2";
        abilities_output.Add("Strength = " + dice_roll.ToString() + mod);
        abilities_output.Add("Dexterity = " + dice_roll.ToString() + mod);
        abilities_output.Add("Constitution = " + dice_roll.ToString()+ mod);
        abilities_output.Add("Intelligence = " + dice_roll.ToString()+ mod);
        abilities_output.Add("Wisdom = " + dice_roll.ToString()+ mod);
        abilities_output.Add("Charisma = " + dice_roll.ToString()+ mod);
        Debug.Log(abilities_output);
        controller.wizard.Abilities = abilities_output;
        Debug.Log("in click dice method");
    }


}
