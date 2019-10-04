using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WUI_Component : MonoBehaviour
{
    public PlayerClass wizard;

    private void Start()
    {
        wizard = new PlayerClass();
    }

    public void switchScenes(string scenename)
    {
        SceneManager.LoadScene(scenename);
        Debug.Log("hello");

    }


    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }


    public void JsonOutput()
    {
        GameObject output_field = GameObject.Find("output_box");
        TMPro.TMP_InputField output_box = output_field.GetComponent<TMPro.TMP_InputField>();
        output_box.text = JsonUtility.ToJson(wizard);
    }

    public void getName()
    {
        GameObject name = GameObject.Find("name_field");
        TMPro.TMP_InputField name_field = name.GetComponent<TMPro.TMP_InputField>();
        string x = name_field.text;
        Debug.Log(x);
        wizard.Name = x;
    }


}
