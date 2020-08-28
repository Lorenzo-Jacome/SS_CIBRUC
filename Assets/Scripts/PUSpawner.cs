using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpawner : MonoBehaviour
{
    public GameObject pu1, pu2, pu3;
    public Transform spawnPos;
    public float rangeFrom;
    public float rangeTo;
    int puToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(powerUpSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator powerUpSpawner() {
        for (int i = 0; i <= 10; i++) { 
            yield return new WaitForSeconds(Random.Range(rangeFrom, rangeTo));
            puToSpawn = Random.Range(1, 4);

            if (puToSpawn == 1) {
                Instantiate(pu1, spawnPos.position, spawnPos.rotation);
            } else if (puToSpawn == 2) {
                Instantiate(pu2, spawnPos.position, spawnPos.rotation);
            } else if (puToSpawn == 3) {
                Instantiate(pu3, spawnPos.position, spawnPos.rotation);
            }
        }
    }
}
