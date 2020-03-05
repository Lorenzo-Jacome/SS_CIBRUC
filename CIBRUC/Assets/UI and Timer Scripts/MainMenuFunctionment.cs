/*
    Author: Rodrigo Quiroz Reyes
    February 29, 2020
    Description: This scripts controls functionment from the Main Menu and Options/Setting Area of the game
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunctionment : MonoBehaviour
{
    //Definition of Main Menu Components and settingss area components 
    public GameObject optionsMenu;
    public GameObject mainMenuButtons;
    public GameObject mainMenuPanel;

    public GameObject nivelesMenu;

    
    //Boolean variable for controls' pannel apperance
    public bool controlsApperance;

    void Start(){
        
    }
    public void Awake()
    {

        controlsApperance = false;
    }
    
    public void Update()
    {
        if(!controlsApperance)
        {
            optionsMenu.SetActive(false);
        }
        if(Input.GetButtonDown("Back"))
        {
            ReturnMainMenu();
        }
    }

    public void OpenOptionsSettings() //Options area is opened
    {
        mainMenuButtons.SetActive(false);
        optionsMenu.SetActive(true);
        controlsApperance = true;
    }


    public void ReturnMainMenu() //Players return to Main Menu
    {
        nivelesMenu.SetActive(false);
        optionsMenu.SetActive(false);
        mainMenuButtons.SetActive(true);
        controlsApperance = false;
    }
    public void jugar() 
    {
        nivelesMenu.SetActive(true);
        mainMenuButtons.SetActive(false);
        controlsApperance = false;
    }

    public void level1() 
    {
        SceneManager.LoadScene("Nivel 1");

    }
    public void level2() 
    {
        SceneManager.LoadScene("Nivel 2");

    }
    public void level3() 
    {
        SceneManager.LoadScene("Nivel 3");

    }
    
    /*public void exitGame() 
    {
        if(UnityEditor.EditorApplication.isPlaying){
            UnityEditor.EditorApplication.isPlaying=false;
        }
        else
        Application.Quit();

    } */

   
}