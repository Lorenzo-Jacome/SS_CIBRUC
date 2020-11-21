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
    public GameObject particles;
    public AudioClip deathSound;
    public AudioSource audioSource;
    void Start()
    {
        
        originPos = transform.position;
         Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>(),false);
    
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
    IEnumerator DieTime(Collision2D col)
    {
        gameObject.GetComponent<Collider2D>().enabled=false;
        gameObject.GetComponent<SpriteRenderer>().enabled=false;
        Instantiate(particles, transform.position, Quaternion.identity);
        Destroy(col.gameObject);
        audioSource.clip=deathSound;
        audioSource.PlayOneShot(deathSound);
        //audioSource.enabled=false;
        yield return new WaitForSeconds(1);         
        Destroy(gameObject);
            

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
            StartCoroutine(DieTime(col));

            //Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "CannonBullet")
        {
            StartCoroutine(DieTime(col));
           // Instantiate(particles, transform.position, Quaternion.identity);
            //Destroy(gameObject);
            
        }

        if (col.gameObject.tag == "Ally" || col.gameObject.tag == "Enemy")
        {
            //StartCoroutine(DieTime(col));
            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            
        }

    }



}
