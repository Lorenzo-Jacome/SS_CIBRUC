﻿/*
    Author: Rodrigo Quiroz Reyes
    Edited by: Lorenzo Jácome Ceniceros and Mr. Spikes
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
    public GameObject settingsMenu;
    public GameObject credits;

    
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

    }

    public void OpenOptionsSettings() //Tutorial area is opened
    {
        mainMenuButtons.SetActive(false);
        optionsMenu.SetActive(true); //Tutorial
        settingsMenu.SetActive(false);
        controlsApperance = true; 
    }

    public void ReturnMainMenu() //Players return to Main Menu
    {
        nivelesMenu.SetActive(false);
        optionsMenu.SetActive(false);
        settingsMenu.SetActive(false);
        mainMenuButtons.SetActive(true);
        credits.SetActive(false);
        controlsApperance = false;
    }

    public void OpenSettings() //Settings area is open.
    {
        nivelesMenu.SetActive(false);
        optionsMenu.SetActive(false);
        settingsMenu.SetActive(true);
        mainMenuButtons.SetActive(false);
        credits.SetActive(false);
        controlsApperance = true;
    }

    public void OpenCredits() {

        credits.SetActive(true);
        nivelesMenu.SetActive(false);
        optionsMenu.SetActive(false);
        settingsMenu.SetActive(false);
        mainMenuButtons.SetActive(false);
        controlsApperance = true;

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