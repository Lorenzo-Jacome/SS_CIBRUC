using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    int totalEnemigos = 0;

    public Transform enemyPos;
    public int numberEnemies;
    public float rangeFrom;
    public float rangeTo;
    int enemyToSpawn;
    [SerializeField] public int spawnCounter;
    [SerializeField] public GameObject winMenu;
    public GameObject[] enemyList = new GameObject[13];

     // Start is called before the first frame update
     void Start()
    {
        StartCoroutine(enemySpawner());

        spawnCounter = numberEnemies;
        //Screen.SetResolution(1920, 1080, true);
        

    }

    // Update is called once per frame
    void Update()
    {

        int numberOfEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        int numberOfAllies = GameObject.FindGameObjectsWithTag("Ally").Length;
         

        if (spawnCounter == 0 && numberOfEnemies == 0 && numberOfAllies == 0)
        {

            winMenu.SetActive(true);

        }

    }

    IEnumerator enemySpawner()
    {
        for (int i = 0; i < numberEnemies; i++)
        {
            yield return new WaitForSeconds(Random.Range(rangeFrom, rangeTo));
            enemyToSpawn = Random.Range(1, 10);

            Instantiate(enemyList[enemyToSpawn], enemyPos.position, enemyPos.rotation);

            spawnCounter--;

        }
    }
}