using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update

    /*public GameObject greenObject;
    public GameObject redObject;
    public GameObject yellowObject;
    public GameObject blueObject; */

    public bool FreezeY = false;
    private Vector3 originPos;

    void Start()
    {
        
        originPos = transform.position;
    
    }

    [SerializeField] public float speed;
    public Transform obj;

    public void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 tempVect = new Vector3(-speed, 0, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;

        obj.transform.position += tempVect;

        Vector3 currentPos = transform.position;
        if (FreezeY)
        {
            currentPos.y = originPos.y;
        }
        transform.position = currentPos;

    }
    
    void OnCollisionEnter2D(Collision2D col)
    {

        /*if(GameObject.FindGameObjectWithTag("GreenEnemy")) {
            Destroy(greenObject);
        }
        if(GameObject.FindGameObjectWithTag("RedEnemy")) {
            Destroy(redObject);
        }
        if(GameObject.FindGameObjectWithTag("YellowEnemy")) {
            Destroy(yellowObject);
        } 
        if(GameObject.FindGameObjectWithTag("BlueEnemy")) {
            Destroy(blueObject);
        } 
       
        Destroy(col.gameObject);    */


        if (col.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Ally" || col.gameObject.tag == "Enemy")
        {
            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

    }

}
