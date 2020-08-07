using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mainmenu2 : MonoBehaviour {



    [SerializeField] string cambiar="Nivel 1";
    public void Nivel()
    {
        SceneManager.LoadScene(cambiar,LoadSceneMode.Single);
    }
   


}