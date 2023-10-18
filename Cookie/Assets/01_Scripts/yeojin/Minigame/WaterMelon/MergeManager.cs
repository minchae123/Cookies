using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeManager : MonoBehaviour
{
    public static MergeManager Instance;
    [SerializeField] private MergeObjectSO[] objectSO;

    private void Awake()
    {
        if (Instance != null) 
        {
            Debug.Log("머지매니저 오류");
        }
        Instance = this;
    }

    public void CheckObject(int id)
    {
        Debug.Log($"id:{id}");
    }
}
