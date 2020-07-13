using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disparo : MonoBehaviour
{

    [SerializeField] public Transform puntaPistola;
    [SerializeField] public GameObject balaDefault;
    [SerializeField] public GameObject balaSnipper;
    [SerializeField] public GameObject balaCannon;
    [SerializeField] public int currentBullet;
    public float rateOfFire;
    private bool permitirDisparo;
    public GameObject manager;
    public int sum = 0;
    private Vector2 direccionBala;
    private float angulo;

    int counterForDemo = 0;

    void Awake()
    {
        //The player is allowed to shoot at the start:
        permitirDisparo = true;
        //currentBullet = 0;

    }

    void Start()
    {

        permitirDisparo = true;

        //currentBullet = 0;

    }

    void Update()
    {
        Touch touch = Input.GetTouch(0);
        direccionBala = Camera.main.ScreenToWorldPoint(touch.position) - transform.position;
        angulo = Mathf.Atan2(direccionBala.y, direccionBala.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angulo - 90f + 70f);




    }

    public void dispararBala()
    {

        GameObject currentBulletObject;
        float bulletSpeed;

        switch (currentBullet)
        {

            case 0:
                //Default:
                currentBulletObject = balaDefault;
                bulletSpeed = 10f;
                rateOfFire = 0.3f;
                Debug.Log("Entra 0");
                break;

            case 1:
                //Snipper:
                currentBulletObject = balaSnipper;
                bulletSpeed = 20f;
                rateOfFire = 0.6f;
                Debug.Log("Entra 1");
                break;

            case 2:
                //CannonBall:
                currentBulletObject = balaCannon;
                bulletSpeed = 5f;
                rateOfFire = 1.0f;
                Debug.Log("Entra 2");
                break;

            default:
                //Default:
                currentBulletObject = balaDefault;
                bulletSpeed = 10f;
                rateOfFire = 0.3f;
                Debug.Log("Entra default");
                break;

        }

        if (permitirDisparo)
        {
            //Block the player from spamming the fire button:
            permitirDisparo = false;

            //Instanciate a new bullet object with the cannon properties:
            GameObject disparar = Instantiate(currentBulletObject, puntaPistola.position, puntaPistola.rotation);

            //Shoot the bullet with a given velocity:
            disparar.GetComponent<Rigidbody2D>().velocity = puntaPistola.up * bulletSpeed;

            //Start a coroutine to wait for the given rate of fire before allowing the player to fire again:
            StartCoroutine(limitFire());

        }

    }

    IEnumerator limitFire()
    {

        //Wait for the given rate of fire:
        yield return new WaitForSeconds(rateOfFire);

        //Allow player to shoot again:
        permitirDisparo = true;

    }

}
