using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public TextMeshProUGUI secondsSurvivedUI;
    [SerializeField] private Material myMaterial;
    bool gameOver;

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    public void OnGameOver()
    {
        gameOverScreen.SetActive(true);
        secondsSurvivedUI.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
        gameOver = true;
    }

    public void Back()
    {
        SceneManager.LoadScene("StartScene");
        myMaterial.color = Color.white;
    }
}
