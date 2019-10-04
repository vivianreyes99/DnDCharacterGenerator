using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Races : MonoBehaviour
{
    public Dictionary<string, string> RacesDictionary = new Dictionary<string, string>();
    public List<string> race = new List<string>() {"Dragonborn", "Dwarf", "Elf", "Gnome", "Half-Elf",
        "Half-Orc", "Halfling", "Human", "Tiefling"};
    public List<string> output = new List<string>();
    public TMPro.TMP_Dropdown dropdown;

    public WUI_Component controller;


    private void Start()
    {
        dropdown = GameObject.Find("Race_Dropdown").GetComponent<TMPro.TMP_Dropdown>();
        controller = GameObject.Find("UI_Controller").GetComponent<WUI_Component>();
        dropdown.AddOptions(race);
    }


    public Races()
    {
        RacesDictionary.Add("Dragonbon", "Yout draconic heritage mainfests in a variety of traits you share with other dragonborn");
        RacesDictionary.Add("Dwarf", "Your dwarf character has an assortment of in abilities, part and parcel of dwarven nature");
        RacesDictionary.Add("Elf", "Your elf character has a variety of natural abilities, the result of thousands of years of elven refinement");
        RacesDictionary.Add("Gnome", "Your gnome character has certain characteristics in common with all other gnomes.");
        RacesDictionary.Add("Half-Elf", "Your half-elf character has some qualities in common with elves and some that are unique to half-elves.");
        RacesDictionary.Add("Half-Orc", "Your half-orc character has certain traits deriving from your orc ancestry");
        RacesDictionary.Add("Halfling", "Your halfling character has a number of traits in common with all other halflings.");
        RacesDictionary.Add("Human", "It's hard to make generalizations about humans, but your human character has these traits.");
        RacesDictionary.Add("Tiefling", "Tieflings share certain racial traits as a result of their infernal descent.");
    }


    public void getRaceFromUser(int index)
    {
        string selectedRace = dropdown.options[index].text;
        controller.wizard.Race = selectedRace;

    }

    
  

}
