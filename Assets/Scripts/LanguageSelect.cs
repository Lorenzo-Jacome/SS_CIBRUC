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

    public Text tutorial_title;

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

    //Settings:
    public Image settings_title;
    public Sprite settimgs_title_esp;
    public Sprite settimgs_title_eng;

    public Image settings_music;
    public Sprite settings_music_eng;
    public Sprite settings_music_esp;

    public Image settings_ambient;
    public Sprite settings_ambient_eng;
    public Sprite settings_ambient_esp;

    //Credits:
    public Text credits_button_text;

    public Text credits_roles;

    public Text credits_title;
    public string credits_title_esp;
    public string credits_title_eng;

    public Button credits_back;
    public Sprite credits_back_esp;
    public Sprite credits_back_eng;

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

            credits_button_text.text = "Créditos";

            levels_background.sprite = esp_levels_background;

            settings_title.sprite = settimgs_title_esp;
            settings_music.sprite = settings_music_esp;
            settings_ambient.sprite = settings_ambient_esp;

            credits_title.text = credits_title_esp;
            credits_roles.text = "Director de desarrollo\nSubdirector de desarrollo\nDirector de audio\nDesarrollador en audio\nDiseño e implementación de UI\nDiseño e implementación de UI\nProgramación general\nProgramación general\nDesarrollador de audio\nDesarrollador de audio\nProgramación Traducción\nImplementación Traducción\nDiseño de gameplay\nPruebas";

            Image creditsBackImage = credits_back.GetComponent<Image>();
            creditsBackImage.sprite = credits_back_esp;

            tutorial_title.text = "Presiona un bote para aprender más:";

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

            credits_button_text.text = "Credits";

            settings_title.sprite = settimgs_title_eng;
            settings_music.sprite = settings_music_eng;
            settings_ambient.sprite = settings_ambient_eng;

            credits_title.text = credits_title_eng;
            credits_roles.text = "Director of Development\nSubdirector of Development\nAudio direction\nAudio design\nUI\nUI\nProgrammer\nProgrammer\nAudio development\nAudio development\nTranslation systems programmer\nTranslation implementation\nGameplay Design\nTesting";

            Image creditsBackImage = credits_back.GetComponent<Image>();
            creditsBackImage.sprite = credits_back_eng;

            tutorial_title.text = "Select a trash can to learn more:";

        }

    }

}
