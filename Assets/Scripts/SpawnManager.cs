using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // public variables with tooltips
    [Tooltip("Animal Prefab")][SerializeField] public GameObject[] animalPrefab;        // array of animal prefabs

    // private variables
    private float spawnRangeX = 10f;        // spawn range in x axis
    private float spawnPosZ = 60f;          // spawn position in z axis
    private float spawnDelay = 2f;          // delay before spawning
    private float spawnInterval = 1.5f;     // interval between spawns

    // Start is called before the first frame update
    void Start() 
    {
        InvokeRepeating(nameof(spawnAnimal), spawnDelay, spawnInterval);      // invoke spawnAnimal method with delay and interval
    }

    void spawnAnimal ()
    {
        // generate random animal spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        // generate random animal index for animal prefab array
        int animalIndex = Random.Range(0, animalPrefab.Length);
        
        // spawn animal at random position
        Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
    }
}
