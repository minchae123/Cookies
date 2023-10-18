using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeSpawner : MonoBehaviour
{
    public static MergeSpawner Instance;

    private GameObject currentObj;
    [SerializeField] private MergeObjectSO[] mergeSO;

    private void Awake()
    {
        if (Instance != null) print("���������� ����");
        Instance = this;
    }

    private void Start()
    {
        int rand = Random.Range(0, 2); // 0~2 ���� ������ �����ϰ� ����
        currentObj = mergeSO[rand].mergePrefab;
        Instantiate(currentObj);
    }

    public void ReSpawn()
    {
        currentObj = null;
        int rand = Random.Range(0, 2); // 0~2 ���� ������ �����ϰ� ����
        currentObj = mergeSO[rand].mergePrefab;
        print(mergeSO[rand].level);
        Instantiate(currentObj);
    }
}
