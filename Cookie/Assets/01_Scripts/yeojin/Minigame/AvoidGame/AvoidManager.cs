using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class AvoidManager : MonoBehaviour
{
    public static AvoidManager Instance;
        
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI overText;

    [SerializeField] private GameObject panel;

    private bool isGameOver = false;
    public bool IsGameOver => isGameOver;

    private bool isGameSuccess = false;

    private int score = 0;

    private float currentTime = 0f;
    [SerializeField] private float gameTime = 30f;

    private void Awake()
    {
        if (Instance != null) 
        {
            Debug.LogError("Multiple AvoidManager");
        }
        Instance = this;
    }

    private void Update()
    {
        if (isGameOver) return;

        scoreText.text = $"Score: {score}";

        currentTime += Time.deltaTime;

        float time = gameTime - currentTime;
        time = Mathf.Clamp(time, 0f, gameTime);
        timerText.text = $"{Mathf.FloorToInt(time / 60) % 60:00}:{time % 60:00}";

        if(time <= 0.0f)
        {
            isGameSuccess = true;
            GameOver();
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        panel.transform.DOLocalMoveY(0, 1.5f);
        overText.text = isGameSuccess ? $"�̴ϰ��� ����!\n���� �α�: {score}" : $"�̴ϰ��� ����. . .\n���� ��ȸ�� ���������!";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // ���� �� ��ε�
        Debug.Log("�ٽý���");
    }

    public void GoBackButton()
    {
        Debug.Log("������");
    }

    public void AddScore()
    {
        score++;
    }
}
