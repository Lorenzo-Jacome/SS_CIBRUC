using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalValues : MonoBehaviour
{

    public int language;

    void Awake() {

        GameObject[] objs = GameObject.FindGameObjectsWithTag("GValues");

        if (objs.Length > 1)
        {

            Destroy(this.gameObject);

        }

        DontDestroyOnLoad(this.gameObject);

    }

    public void selectedLanguage(int selection)
    {

        language = selection;

    }

}
