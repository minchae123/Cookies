using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class MergeObj
{
    public int level; // 레벨 // 리스트 레벨 순으로 정리
    public GameObject mergePrefab;
}
[CreateAssetMenu(menuName = "SO/MiniGame/WaterMelon/Object")]
public class MergeObjectSO : ScriptableObject
{
    public List<MergeObj> mergeList;   
}
