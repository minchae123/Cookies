using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class mergeClass
{
    public Sprite objSprite;
    public float scale; // �������� Ŀ���� ��
}
[CreateAssetMenu(menuName = "SO/MiniGame/WaterMelon/Object")]
public class MergeObjectSO : ScriptableObject
{
    public List<mergeClass> Lists;
}
