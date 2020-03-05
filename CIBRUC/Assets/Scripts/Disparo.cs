using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disparo : MonoBehaviour
{

    [SerializeField] public Transform puntaPistola;
    [SerializeField] public GameObject bala;
    public static bool permitirDisparo = true;
    public GameObject manager;
    

    void Awake()
    {

    }

    private Vector2 direccionBala;
    private float angulo;

    void Update()
    {
        Touch touch = Input.GetTouch(0);
        direccionBala = Camera.main.ScreenToWorldPoint(touch.position) - transform.position;
        angulo = Mathf.Atan2(direccionBala.y, direccionBala.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angulo - 90f);
    }

    public  void dispararBala() {


            permitirDisparo = false;

            GameObject disparar = Instantiate(bala, puntaPistola.position, puntaPistola.rotation);
            disparar.GetComponent<Rigidbody2D>().velocity = puntaPistola.up * 10f;

            Debug.Log("Si entra");
            Debug.Log(permitirDisparo);

            StartCoroutine("waitTwoSeconds");

            permitirDisparo = true;

        

    }

    IEnumerator waitTwoSeconds()
    {

        yield return new WaitForSeconds(2);

    }

}
