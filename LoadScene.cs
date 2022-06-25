using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    //Script meant for the buttons in the KeuzeMenu scene. The idea was that the UnityEvent OnClick() in the buttons was linked to each of these functions.
    //I was never able to find out whether it worked due to handtracking UI issues.
    public void LoadILY()
    {
        SceneManager.LoadScene(2); //Load scene
    }

    public void LoadYES()
    {
        SceneManager.LoadScene(3); //Load scene
    }

    public void LoadNO()
    {
        SceneManager.LoadScene(4); //Load scene
    }

    public void LoadFreestyle()
    {
        SceneManager.LoadScene(5); //Load scene
    }

}
