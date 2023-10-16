using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AvoidManager : MonoBehaviour
{
    public static AvoidManager Instance;

    [SerializeField] private TextMeshProUGUI scoreText;
    private int score = 0;
    
    private void Awake()
    {
        if (Instance != null) 
        {
            Debug.LogError("Multiple");
        }
        Instance = this;
        score = 0;
    }

    private void Update()
    {
        scoreText.text = $"Score: {score}";
    }

    public void AddScore()
    {
        score++;
    }
}
