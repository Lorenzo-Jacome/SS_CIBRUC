using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSelect : MonoBehaviour
{

    //Objects to translate:

    //Main menu buttons:
    public Button play;
    public Sprite eng_play;
    public Sprite esp_play;

    public Button tutorial;
    public Sprite eng_tutorial;
    public Sprite esp_tutorial;

    public Button options;
    public Sprite eng_options;
    public Sprite esp_options;

    //Back buttons:
    public Button tutorial_back;
    public Sprite eng_tutorial_back;
    public Sprite esp_tutorial_back;

    public Button levels_back;
    public Sprite eng_levels_back;
    public Sprite esp_levels_back;

    public Button options_back;
    public Sprite eng_options_back;
    public Sprite esp_options_back;

    //Backgrounds:
    public Image levels_background;
    public Sprite eng_levels_background;
    public Sprite esp_levels_background;


    public void selectLanguage(int selection) {

        GameObject global = GameObject.Find("GlobalValues");
        GlobalValues globalScript = global.GetComponent<GlobalValues>();
        globalScript.language = selection;

        if (selection == 0)
        {
            //Español:
            Image playImage = play.GetComponent<Image>();
            playImage.sprite = esp_play;

            Image tutorialImage = tutorial.GetComponent<Image>();
            tutorialImage.sprite = esp_tutorial;

            Image optionsImage = options.GetComponent<Image>();
            optionsImage.sprite = esp_options;

            Image tutorialBackImage = tutorial_back.GetComponent<Image>();
            tutorialBackImage.sprite = esp_tutorial_back;

            Image levelsBackImage = levels_back.GetComponent<Image>();
            levelsBackImage.sprite = esp_levels_back;

            Image optionsBackImage = options_back.GetComponent<Image>();
            optionsBackImage.sprite = esp_options_back;

            levels_background.sprite = esp_levels_background;


        }
        else {

            //English:
            Image playImage = play.GetComponent<Image>();
            playImage.sprite = eng_play;

            Image tutorialImage = tutorial.GetComponent<Image>();
            tutorialImage.sprite = eng_tutorial;

            Image optionsImage = options.GetComponent<Image>();
            optionsImage.sprite = eng_options;

            Image tutorialBackImage = tutorial_back.GetComponent<Image>();
            tutorialBackImage.sprite = eng_tutorial_back;

            Image levelsBackImage = levels_back.GetComponent<Image>();
            levelsBackImage.sprite = eng_levels_back;

            Image optionsBackImage = options_back.GetComponent<Image>();
            optionsBackImage.sprite = eng_options_back;

            levels_background.sprite = eng_levels_background;

            //Update play button size due to scale problems:
            play.image.rectTransform.sizeDelta = new Vector2(33f, 21.07f);

        }

    }

}
