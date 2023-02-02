using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // public variables with tooltips
    // Game over canvas
    [Tooltip("Game Over Canvas")][SerializeField] public GameObject gameOverCanvas;     // Game over canvas
    
    // private variables
    private float topbound = 90f;       // top bound
    private float lowerbound = -20f;    // lower bound
    // Start is called before the first frame update
    // void Start() { }

    // destroys the object if it goes out of bounds
    void DestroyObject()
    {
        if (transform.position.z > topbound)
        {
            Destroy(gameObject);    // Destroy the animal
        }
        else if (transform.position.z < lowerbound)
        {
            // gameOverCanvas.SetActive(true);     // Show the game over canvas
            Time.timeScale = 0;                 // Stop the game
            Destroy(gameObject);                // Destroy the animal
            Debug.Log("Game Over!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        DestroyObject();
    }
}