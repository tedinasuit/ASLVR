using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPose : MonoBehaviour
{
    [SerializeField] private string newLevel;
    private void InBox(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene(newLevel);
            System.Console.WriteLine("N pressed");
        }

        
    }
}
