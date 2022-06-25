using System.Collections;
using Oculus.Interaction;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PoseDetector : MonoBehaviour
{

    public List<ActiveStateSelector> poses; //list (poses) with the "items" that are active in the Active State Selector component
    public TMPro.TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in poses)
        {
            item.WhenSelected += () => SceneManager.LoadScene("KeuzeMenu"); //Loads KeuzeMenu scene when item is selected
        }
    }
}
