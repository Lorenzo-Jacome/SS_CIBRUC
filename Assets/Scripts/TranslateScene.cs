using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranslateScene : MonoBehaviour
{

    public int language;

    //Game texts to translate:
    //UI:
    public Text shootButton;

    //Pause Menu:
    public Text pauseMenuHeader;
    public Text resumeButton;
    public Text restartButton;
    public Text exitButton;

    //Game Over:
    public Text gameOverHeader;
    public Text returnToMenuOver;
    public Text gameOverScore;

    //Game Won:
    public Text gameWonHeather;
    public Text gameWonScore;
    public Text gameWonExit;

    
    void Start()
    {

        GameObject global = GameObject.Find("GlobalValues");
        GlobalValues globalScript = global.GetComponent<GlobalValues>();
        language = globalScript.language;

        translate();

        Debug.Log("Si traduce a: " + language);

    }

    void translate() {

        if (language == 1)
        {
            //English:

            //UI:
            shootButton.text = "FIRE";

            //Pause Menu:
            pauseMenuHeader.text = "PAUSE MENU";
            resumeButton.text = "Resume";
            restartButton.text = "Restart Level";
            exitButton.text = "Exit";

            //Game Over:
            gameOverHeader.text = "GAME OVER";
            returnToMenuOver.text = "Return to main menu";
            gameOverScore.text = "Score: ";

            //Game Won:
            gameWonHeather.text = "YOU WON!";
            gameWonScore.text = "Score: ";
            gameWonExit.text = "Return to main menu";

        } else
        {
            //Español:

            //UI:
            shootButton.text = "DISPARAR";

            //Pause Menu:
            pauseMenuHeader.text = "MENÚ DE PAUSA";
            resumeButton.text = "Reanudar";
            restartButton.text = "Reiniciar Nivel";
            exitButton.text = "Salir";

            //Game Over:
            gameOverHeader.text = "FIN DEL JUEGO";
            returnToMenuOver.text = "Regresar al menú principal";
            gameOverScore.text = "Puntuación: ";

            //Game Won:
            gameWonHeather.text = "GANASTE!";
            gameWonScore.text = "Puntuación: ";
            gameWonExit.text = "Regresar al menú principal";

        }

    }

}
