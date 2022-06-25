using System.Collections;
using Oculus.Interaction;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Freestyle : MonoBehaviour
{

    public List<ActiveStateSelector> poses; //list (poses) with the "items" that are active in the Active State Selector component
    public TMPro.TextMeshPro text; //will allow to add text prefab to script component in Unity Editor
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in poses)
        {
            item.WhenSelected += () => SetTextToPoseName(item.gameObject.name); //Change string of SetTextToPoseName to selected item
            item.WhenUnselected += () => SetTextToPoseName("Maak een gebaar"); //Set default text when there's no item selected
        }
    }


    //Content within parentheses will be send to the script component in the Unity Editor.
    private void SetTextToPoseName(string newText) 
    {
        text.text = newText;    
    }
}
