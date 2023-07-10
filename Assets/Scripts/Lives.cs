using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    
    public GameObject livesScreen;
    public TextMeshProUGUI livesCountUI;
    bool lives;
    // Start is called before the first frame update
    void start()
    {
        
    }

// Update is called once per frame
    void Update()
    {
        
    }

    public void OnLives()
    {
        int livesCount = GameObject.FindObjectOfType<PlayerController>().livesCount;
        livesCountUI.text = livesCount.ToString();
    }
}
