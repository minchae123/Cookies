using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class AvoidManager : MonoBehaviour
{
    public static AvoidManager Instance;
        
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject panel;

    private bool isGameOver = false;
    public bool IsGameOver => isGameOver;

    private int score = 0;
    
    private void Awake()
    {
        if (Instance != null) 
        {
            Debug.LogError("Multiple AvoidManager");
        }
        Instance = this;
    }

    private void Start()
    {
        score = 0;
        isGameOver = false;
    }

    private void Update()
    {
        scoreText.text = $"Score: {score}";
    }

    public void GameOver()
    {
        isGameOver = true;
        panel.transform.DOLocalMoveY(0, 1.5f);
    }

    public void AddScore()
    {
        score++;
    }
}
