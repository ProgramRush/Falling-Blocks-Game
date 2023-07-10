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
        startScreen.SetActive(false);
        customScreen.SetActive(true);
    }

    public void BackToHome()
    {
        startScreen.SetActive(true);
        customScreen.SetActive(false);
    }

    public void Controls()
    {
        startScreen.SetActive(false);
        controlsScreen.SetActive(true);
    }
    public void ControlsBackHome()
    {
        startScreen.SetActive(true);
        controlsScreen.SetActive(false);
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
