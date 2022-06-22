using System.Collections;
using Oculus.Interaction;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class loadILY : MonoBehaviour
{

    public List<ActiveStateSelector> poses;
    public TMPro.TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in poses)
        {
            item.WhenSelected += () => SceneManager.LoadScene("ILY");
            item.WhenUnselected += () => SetTextToPoseName("");
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
