using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoadSelected : MonoBehaviour
{

    public Dropdown langDropdown;

    void Start()
    {

        GameObject global = GameObject.Find("GlobalValues");
        GlobalValues globalScript = global.GetComponent<GlobalValues>();
        int language = globalScript.language;

        langDropdown.value = language;

    }

}
