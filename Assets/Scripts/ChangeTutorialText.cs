using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTutorialText : MonoBehaviour
{

    public Text titleObject;
    public Text descriptionObject;

    public string titleSpanish;
    public string titleEnglish;

    public string descriptionSpanish;
    public string descriptionEnglish;

    public void displayTutorialText() {

        //Get the global variable for the selected language:
        GameObject global = GameObject.Find("GlobalValues");
        GlobalValues globalScript = global.GetComponent<GlobalValues>();
        int language = globalScript.language;

        if (language == 0)
        {
            //Español:

            titleObject.text = titleSpanish;
            descriptionObject.text = descriptionSpanish;

        }
        else
        {

            //English:

            titleObject.text = titleEnglish;
            descriptionObject.text = descriptionEnglish;

        }

    }

}
