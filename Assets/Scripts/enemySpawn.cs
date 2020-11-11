using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    int totalEnemigos = 0;

    public GameObject enemy1, enemy2, enemy3, enemy4, enemy5, enemy6, enemy7, enemy8, enemy9, enemy10, enemy11, enemy12, enemy13;
    public Transform enemyPos;
    public int numberEnemies;
    public float rangeFrom;
    public float rangeTo;
    int enemyToSpawn;
    [SerializeField] public int spawnCounter;
    [SerializeField] public GameObject winMenu;

    public AudioClip[] sounds;
    public AudioSource source;

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
            enemyToSpawn = Random.Range(1, 14);

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
            else if (enemyToSpawn == 4)
            {
                Instantiate(enemy4, enemyPos.position, enemyPos.rotation);
            }
            else if (enemyToSpawn == 5)
            {
                Instantiate(enemy5, enemyPos.position, enemyPos.rotation);
            }
            else if (enemyToSpawn == 6)
            {
                Instantiate(enemy6, enemyPos.position, enemyPos.rotation);
            }
            else if (enemyToSpawn == 7)
            {
                Instantiate(enemy7, enemyPos.position, enemyPos.rotation);
            }
            else if (enemyToSpawn == 8)
            {
                Instantiate(enemy8, enemyPos.position, enemyPos.rotation);
            }
            else if (enemyToSpawn == 9)
            {
                Instantiate(enemy9, enemyPos.position, enemyPos.rotation);
            }
            else if (enemyToSpawn == 10)
            {
                Instantiate(enemy10, enemyPos.position, enemyPos.rotation);
            }
            else if (enemyToSpawn == 11)
            {
                Instantiate(enemy11, enemyPos.position, enemyPos.rotation);
            }
            else if (enemyToSpawn == 12)
            {
                Instantiate(enemy12, enemyPos.position, enemyPos.rotation);
            }
            else if (enemyToSpawn == 13)
            {
                Instantiate(enemy13, enemyPos.position, enemyPos.rotation);
            }

            //Sonido
            source = gameObject.GetComponent<AudioSource>();
            source.clip = sounds[Random.Range(0,sounds.Length)];
            source.Play();
            Debug.Log(source.clip);
            spawnCounter--;

        }
    }
}