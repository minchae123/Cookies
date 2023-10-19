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
        if (Instance != null) print("�����Ŵ�������");
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
        print("�ٽý���");
    }

    public void GoBackButton()
    {
        print("������");
    }

    public void AddScore(int value)
    {
        score += value;
    }

    public void SetGameOver()
    {
        print("����");
        isGameOver = true;
        gameOverPanel.transform.DOLocalMoveY(0, 1.5f);
        gameOverText.text = $"�̴ϰ��� ����!\n���� �α�: {score}";
    }
}
