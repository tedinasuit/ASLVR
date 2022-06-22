using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadILY()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadYES()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadNO()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadFreestyle()
    {
        SceneManager.LoadScene(5);
    }

}
