using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResizeButton : MonoBehaviour
{

    public Button thisButton;

    public void resizeClickedButton(string type) {

        type = type.ToLower();

        switch (type) {

            case "reduce":

                thisButton.image.rectTransform.sizeDelta = new Vector2(135, 200);
                break;

            case "increase":
                thisButton.image.rectTransform.sizeDelta = new Vector2(235, 300);
                break;

            default:
                thisButton.image.rectTransform.sizeDelta = new Vector2(135, 200);
                break;

        }

    }

}
