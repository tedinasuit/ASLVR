using System.Collections;
using Oculus.Interaction;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class loadFreestyle : MonoBehaviour
{

    public List<ActiveStateSelector> poses; //list (poses) with the "items" that are active in the Active State Selector component
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in poses)
        {
            item.WhenSelected += () => SceneManager.LoadScene("Freestyle"); //Loads Freestyle scene when item is selected
        }
    }
}
