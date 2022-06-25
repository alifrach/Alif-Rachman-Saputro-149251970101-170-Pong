using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitController : MonoBehaviour
{
    public KeyCode exKey;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(exKey))
        {
            Application.Quit();
        }
    }
}
