using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MergeManager : MonoBehaviour
{
    public static MergeManager Instance;

    [SerializeField] private GameObject prefab;
    private int score;
    private bool isGameOver;
    public bool IsGameOver => isGameOver;

    [Header("UI")]
    [SerializeField] private TextMeshProUGUI scoreText;
    [Header("GameOverUI")]
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TextMeshProUGUI gameOverText;

    private void Awake()
    {
        if (Instance != null) print("머지매니저에러");
        Instance = this;
    }

    private void Start()
    {
        Instantiate(prefab);
    }

    private void Update()
    {   
        if (isGameOver) return;
        TryInstantiatePrefab();
        scoreText.text = score.ToString();
    }

    private void TryInstantiatePrefab()
    {
        MergePlayer watermelonPlayer = FindObjectOfType<MergePlayer>();
        if (watermelonPlayer == null)
        {
            Instantiate(prefab);
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        print("다시시작");
    }

    public void GoBackButton()
    {
        print("나가기");
    }

    public void AddScore(int value)
    {
        score += value;
    }

    public void SetGameOver()
    {
        print("오버");
        isGameOver = true;
        gameOverPanel.transform.DOLocalMoveY(0, 1.5f);
        gameOverText.text = $"미니게임 성공!\n얻은 인기: {score}";
    }
}
