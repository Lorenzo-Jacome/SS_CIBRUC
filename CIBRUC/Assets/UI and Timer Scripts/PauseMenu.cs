/*
    Esteban Rodrigo Quiroz Reyes
    February 29, 2020
    Description: This scripts controls functionment from the Main Menu and Options/Setting Area of the game
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //GameObject definition for pause menu and pause button
    public GameObject menu;
    public GameObject pauseButton;

    //Boolean variable for pause menu control
    public bool escButtonTrigger;

    Scene current;
 


    void Start(){
        current = SceneManager.GetActiveScene();
    }


    // Update is called once per frame
    void Update() //Determines if Pause Menu can be opened
    {
        if((Input.GetKeyDown(KeyCode.Escape)) && escButtonTrigger == true)
        {
            PauseGame();
        }
        else if((Input.GetKeyDown(KeyCode.Escape)) && escButtonTrigger == false)
        {
            ResumeGame();
        }
        

    }

    public void PauseGame() //The game is paused
    {
        escButtonTrigger = false;
        menu.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void ResumeGame() //The game resumes
    {
        escButtonTrigger = true;
        menu.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1;
    }

    public void RestartGame() //Game is restarted
    {
        print(current.name);
        SceneManager.LoadScene(current.name);
        Time.timeScale = 1;
    }

    public void ExitGame() //Game is ended and Main Menu appears
    {
        SceneManager.LoadScene("Main Menu");
    }
}
