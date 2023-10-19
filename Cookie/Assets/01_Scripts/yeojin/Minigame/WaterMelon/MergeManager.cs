using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MergeManager : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        Instantiate(prefab);
    }

    private void Update()
    {
        TryInstantiatePrefab();
    }

    private void TryInstantiatePrefab()
    {
        WatermelonPlayer watermelonPlayer = FindObjectOfType<WatermelonPlayer>();
        if (watermelonPlayer == null)
        {
            Instantiate(prefab);
        }
    }
}
