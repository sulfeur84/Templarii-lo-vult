using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("LevelDesign");
        }
        
        if(Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
    }
}
