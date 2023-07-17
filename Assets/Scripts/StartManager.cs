using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    // Screens
    public GameObject startScreen;
    public GameObject customScreen;
    public GameObject controlsScreen;
    // Change Sprite/Player Color
    public GameObject sprite;
    [SerializeField] private Material myMaterial; 

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }
    public void CustomScene()
    {
        OnStart(customScreen, startScreen);
    }

    public void BackToHome()
    {
        OnStart(startScreen, customScreen);
    }

    public void Controls()
    {
        OnStart(controlsScreen, startScreen);
    }
    public void ControlsBackHome()
    {
        OnStart(startScreen, controlsScreen);
    }

    void OnStart(GameObject StartUI, GameObject StartUI_2)
    {
        StartUI.SetActive(true);
        StartUI_2.SetActive(false);
    }

    public void Dropdown(int index)
    {
        switch (index)
        {
            case 0:
                sprite.GetComponent<SpriteRenderer>().color = Color.white;
                myMaterial.color = Color.white;
                break;
            case 1:
                sprite.GetComponent<SpriteRenderer>().color = Color.red;
                myMaterial.color = Color.red;
                break;
            case 2:
                sprite.GetComponent<SpriteRenderer>().color = Color.blue;
                myMaterial.color = Color.blue;
                break;
            case 3:
                sprite.GetComponent<SpriteRenderer>().color = Color.yellow;
                myMaterial.color = Color.yellow;
                break;
            case 4:
                sprite.GetComponent<SpriteRenderer>().color = Color.green;
                myMaterial.color = Color.green;
                break;
        }
    }
}
