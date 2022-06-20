using System.Collections;
using Oculus.Interaction;
using System.Collections.Generic;
using UnityEngine;

public class PoseDetector : MonoBehaviour
{

    public List<ActiveStateSelector> poses;
    public TMPro.TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in poses)
        {
            item.WhenSelected += () => SetTextToPoseName(item.gameObject.name);
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