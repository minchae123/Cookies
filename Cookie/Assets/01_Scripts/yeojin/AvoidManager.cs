using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class AvoidManager : MonoBehaviour
{
    public static AvoidManager Instance;
    
    private Spawner spawner;
    
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject panel;

    private bool isGameOver = false;
    public bool IsGameOver => isGameOver;

    private int score = 0;
    
    private void Awake()
    {
        if (Instance != null) 
        {
            Debug.LogError("Multiple");
        }
        Instance = this;
        spawner = transform.GetComponentInChildren<Spawner>();
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
        panel.transform.DOLocalMoveY(0, 1.5f);
        isGameOver = true;
    }

    public void AddScore()
    {
        score++;
    }
}
