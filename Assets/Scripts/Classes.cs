using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Classes : MonoBehaviour
{
    public Dictionary<string, string> ClassDictionary = new Dictionary<string, string>();
    public List<string> classes = new List<string>() {"Barbarian", "Bard", "Cleric", "Druid", "Fighter",
        "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard"};
    public List<string> output = new List<string>();
    public TMPro.TMP_Dropdown dropdown;
    public string selectedClass;
    public WUI_Component controller;

    public Classes()
    {
        ClassDictionary.Add("Barbarian", "In battle, you fight with primal ferocity. For some barbarians, rage is a means to an end–that end being violence.");
        ClassDictionary.Add("Bard", "Whether singing folk ballads in taverns or elaborate compositions in royal courts, bards use their gifts to hold audiences spellbound.");
        ClassDictionary.Add("Cleric", "Clerics act as conduits of divine power.");
        ClassDictionary.Add("Druid", "Druids venerate the forces of nature themselves. Druids holds certain plants and animals to be sacred, and most druids are devoted to one of the many nature deities.");
        ClassDictionary.Add("Fighter", "Different fighters choose different approaches to perfecting their fighting prowess, but they all end up perfecting it.");
        ClassDictionary.Add("Monk", "Coming from monasteries, monks are masters of martial arts combat and meditators with the ki living forces.");
        ClassDictionary.Add("Paladin", "Paladins are the ideal of the knight in shining armor; they uphold ideals of justice, virtue, and order and use righteous might to meet their ends.Acting as a bulwark between civilization and the terrors of the wilderness, rangers study, track, and hunt their favored enemies.");
        ClassDictionary.Add("Ranger", "Acting as a bulwark between civilization and the terrors of the wilderness, rangers study, track, and hunt their favored enemies.");
        ClassDictionary.Add("Rogue", "Rogues have many features in common, including their emphasis on perfecting their skills, their precise and deadly approach to combat, and their increasingly quick reflexes.");
        ClassDictionary.Add("Warlock", "You struck a bargain with an otherworldly being of your choice: the Archfey, the Fiend, or the Great Old One who has imbued you with mystical powers, granted you knowledge of occult lore, bestowed arcane research and magic on you and thus has given you facility with spells.");
        ClassDictionary.Add("Wizard", "The study of wizardry is ancient, stretching back to the earliest mortal discoveries of magic. As a student of arcane magic, you have a spellbook containing spells that show glimmerings of your true power which is a catalyst for your mastery over certain spells.");

    }

    void Start()
    {
        dropdown = GameObject.Find("Class_Dropdown").GetComponent<TMPro.TMP_Dropdown>();
        controller = GameObject.Find("UI_Controller").GetComponent<WUI_Component>();
        dropdown.AddOptions(classes);
        Debug.Log(dropdown == null);
    }


    public void getClassFromUser(int index)
    {
        string selectedRace = dropdown.options[index].text;
        controller.wizard.Class = selectedRace;
    }

   

}
