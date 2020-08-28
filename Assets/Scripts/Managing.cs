using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managing : MonoBehaviour
{
    bool siDispara;

    void Start()
    {
       siDispara = true;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checarDisp() {
        siDispara = false;
    }
}
