using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    public Button button;
    private GameManager gameManager;

    public int dificulty;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDificulty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    
    void SetDificulty()
    {
        Debug.Log(gameObject.name + " - тикнул эту кнопку");
        gameManager.StartGame(dificulty);
    }


    void Update()
    {
        
    }
}
