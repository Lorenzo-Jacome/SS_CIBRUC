using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelControl : MonoBehaviour
{

    public GameObject panel;

    public void showPanel(bool show) {

            panel.SetActive(show);

    }

}
