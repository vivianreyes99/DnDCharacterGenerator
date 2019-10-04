using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alignment : MonoBehaviour
{
    
    public List<string> alignment = new List<string>() {"Lawful Good", "Neutral Good", "Chaotic Good",
        "Lawful Neutral", " Neutral", "Chaotic Neutral",
        "Lawful Evil", "Neutral Evil", "Chaotic Evil"};
    public List<string> output = new List<string>();
    public TMPro.TMP_Dropdown dropdown;
    public WUI_Component controller;

    void Start()
    {
        dropdown = GameObject.Find("Alignment_Dropdown").GetComponent<TMPro.TMP_Dropdown>();
        controller = GameObject.Find("UI_Controller").GetComponent<WUI_Component>();
        dropdown.AddOptions(alignment);
        Debug.Log(dropdown == null);

    }


    public void getAlignmentFromUser(int index)
    {
        string selectedAlignment = dropdown.options[index].text;
        controller.wizard.Alignment = selectedAlignment;
      
    }

    
  
}
