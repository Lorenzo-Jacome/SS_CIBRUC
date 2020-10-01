using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSelect : MonoBehaviour
{

    //Objects with text to translate:

    //Level Select Menu:
    public Text levelsHeader;
    public Text returnToMenu;

    public void selectLanguage(int selection) {

        GameObject global = GameObject.Find("GlobalValues");
        GlobalValues globalScript = global.GetComponent<GlobalValues>();
        globalScript.language = selection;

        if (selection == 0)
        {
            //Español:

            levelsHeader.text = "Niveles:";
            returnToMenu.text = "Regresar al inicio";

        }
        else {

            //English:

            levelsHeader.text = "Levels:";
            returnToMenu.text = "Return to main menu";

        }

    }

}
