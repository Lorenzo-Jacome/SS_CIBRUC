using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject greenObject;
    public GameObject redObject;
    public GameObject yellowObject;
    public GameObject blueObject;

    void Start()
    {
        
    
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
    } 
}
