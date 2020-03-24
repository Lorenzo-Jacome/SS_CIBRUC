using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disparo : MonoBehaviour
{

    [SerializeField] public Transform puntaPistola;
    [SerializeField] public GameObject bala;
    [SerializeField] public float rateOfFire = 0.3f;
    private bool permitirDisparo;
    public GameObject manager;
    public int sum = 0;
    private Vector2 direccionBala;
    private float angulo;


    void Awake()
    {
        //The player is allowed to shoot at the start:
        permitirDisparo = true;

    }

    void Update()
    {
        Touch touch = Input.GetTouch(0);
        direccionBala = Camera.main.ScreenToWorldPoint(touch.position) - transform.position;
        angulo = Mathf.Atan2(direccionBala.y, direccionBala.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angulo - 90f);
    }

    public  void dispararBala() {

        if (permitirDisparo)
        {
            //Block the player from spamming the fire button:
            permitirDisparo = false;

            //Instanciate a new bullet object with the cannon properties:
            GameObject disparar = Instantiate(bala, puntaPistola.position, puntaPistola.rotation);

            //Shoot the bullet with a given velocity:
            disparar.GetComponent<Rigidbody2D>().velocity = puntaPistola.up * 10f;

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
