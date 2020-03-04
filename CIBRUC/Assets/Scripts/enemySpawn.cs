using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject enemy1, enemy2, enemy3, enemy4;
    public Transform enemyPos;
    public int numberEnemies;
    public float rangeFrom;
    public float rangeTo;
    int enemyToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemySpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator enemySpawner() {
        for (int i = 0; i < numberEnemies; i++) {
            yield return new WaitForSeconds(Random.Range(rangeFrom, rangeTo));
            enemyToSpawn = Random.Range(1, 5);

            if (enemyToSpawn == 1)
            {
                Instantiate(enemy1, enemyPos.position, enemyPos.rotation);
            }
            else if (enemyToSpawn == 2)
            {
                Instantiate(enemy2, enemyPos.position, enemyPos.rotation);
            }
            else if (enemyToSpawn == 3)
            {
                Instantiate(enemy3, enemyPos.position, enemyPos.rotation);
            }
            else if (enemyToSpawn == 4) {
                Instantiate(enemy4, enemyPos.position, enemyPos.rotation);
            }
        }
    }
}
