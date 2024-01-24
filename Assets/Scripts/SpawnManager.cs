using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;

    private int spawnRangeX = 15;

    private int spawnPosZ = 25;

    private float spawnStartDelay = 2;

    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnStartDelay, spawnInterval);
    }

    // Update is called once per frames
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animals.Length);

        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animals[animalIndex], spawnPosition, animals[animalIndex].transform.rotation);
    }

}
