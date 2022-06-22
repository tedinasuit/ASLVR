using System.Collections;
using Oculus.Interaction;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Freestyle : MonoBehaviour
{

    public List<ActiveStateSelector> poses;
    public TMPro.TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in poses)
        {
            item.WhenSelected += () => SetTextToPoseName(item.gameObject.name);
            item.WhenUnselected += () => SetTextToPoseName("Maak een gebaar");
        }
    }

    // Update is called once per frame  
    void Update()
    {

    }

    private void SetTextToPoseName(string newText)
    {
        text.text = newText;    
    }
}
