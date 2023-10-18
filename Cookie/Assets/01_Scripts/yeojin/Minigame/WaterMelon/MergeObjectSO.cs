using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class MergeObj
{
    public int level; // ���� // ����Ʈ ���� ������ ����
    public GameObject mergePrefab;
}
[CreateAssetMenu(menuName = "SO/MiniGame/WaterMelon/Object")]
public class MergeObjectSO : ScriptableObject
{
    public List<MergeObj> mergeList;   
}
