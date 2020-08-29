 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenButton : MonoBehaviour
{

    public Text title;

    public void SetTitle(string textColor) {

        textColor = textColor.ToLower();

        switch (textColor) {

            case "green":

                title.color = new Color32(0, 124, 32, 255);
                break;

            case "red":
                title.color = new Color32(220, 16, 16, 255);
                break;

            case "grey":
                title.color = new Color32(75, 75, 75, 255);
                break;

            default:
                title.color = new Color32(75, 75, 75, 255);
                break;

        }

    }

}
