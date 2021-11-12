using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYGOESTO : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("BONUS MALUS");
    }

    public void QuitGame()
    {
        Debug.Log("Quitté !");
        Application.Quit();
    }
}
