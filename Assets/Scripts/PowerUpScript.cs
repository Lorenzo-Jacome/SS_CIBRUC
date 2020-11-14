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

    void OnCollisionEnter2D(Collision2D col) {
        if (gameObject.tag == "NormalPu")
        {
            referenceScript.currentBullet = 0;
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
        else if (gameObject.tag == "SniperPu") {
            referenceScript.currentBullet = 1;
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
        else if (gameObject.tag == "CanonPu")
        {
            referenceScript.currentBullet = 2;
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
        //El verdadero
        else if (gameObject.tag == "CibrucPu")
        {
            TowerScript.puntos += 500;
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }
}
