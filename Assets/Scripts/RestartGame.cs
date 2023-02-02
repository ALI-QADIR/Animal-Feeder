using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
    // restart the scene on click
    public void Restart()
    {
        Time.timeScale = 1;     // Start the game
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);     // Restart the scene
    }
}
