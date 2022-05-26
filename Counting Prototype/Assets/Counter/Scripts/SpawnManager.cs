using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject sphere;
    bool gameIsRunning;
    // Start is called before the first frame update
    void Start()
    {
        gameIsRunning = true;
        StartCoroutine(SpawnDelay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnSphere()
    {
        int zRand = Random.Range(-20, 20);
        Instantiate(sphere, new Vector3(0, 25, zRand), transform.rotation);
    }

    IEnumerator SpawnDelay()
    {
        while (gameIsRunning)
        {
            int randSeconds = Random.Range(3, 5);
            yield return new WaitForSeconds(randSeconds);
            SpawnSphere();
        }
    }
}
