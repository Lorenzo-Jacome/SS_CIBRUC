using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public float speed;
    public float height;
    public float disp;

    GameObject referenceObject;
    Disparo referenceScript;
    public AudioSource powerupSound;
    // Start is called before the first frame update
    void Start()
    {
        referenceObject = GameObject.FindWithTag("Canon");
        referenceScript = referenceObject.GetComponent<Disparo>();
    }

    // Update is called once per frame
    void Update()
    {
        //To make the object float up and down:
        //Modify Height and Speed variables to adjust to preference: (Based on: https://forum.unity.com/threads/how-to-make-an-object-move-up-and-down-on-a-loop.380159/)
        Vector3 position = transform.position;
        float moving = Mathf.Sin(Time.time * speed) + 1.5f;
        transform.position = new Vector3(position.x, moving, position.z) * height;
        transform.Translate(-Vector3.right * disp * Time.deltaTime);
    }
    IEnumerator PowerUpDelete(Collision2D col, int bullet)
    {
        powerupSound.Play();
        gameObject.GetComponent<SpriteRenderer>().enabled=false;
        Destroy(col.gameObject);
        referenceScript.currentBullet = bullet;
        yield return new WaitForSeconds(0.7f);   
        Destroy(gameObject);
       
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (gameObject.tag == "NormalPu")
        {
            StartCoroutine(PowerUpDelete(col,0));
        }
        else if (gameObject.tag == "SniperPu") 
        {
            StartCoroutine(PowerUpDelete(col,1));
        }
        else if (gameObject.tag == "CanonPu")
        {
            StartCoroutine(PowerUpDelete(col,2));
        }
    }
}
