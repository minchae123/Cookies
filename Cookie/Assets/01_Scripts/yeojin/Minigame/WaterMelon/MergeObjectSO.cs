using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class mergeClass
{
    public Sprite objSprite;
    public float scale; // 합쳐지면 커지는 식
}
[CreateAssetMenu(menuName = "SO/MiniGame/WaterMelon/Object")]
public class MergeObjectSO : ScriptableObject
{
    public List<mergeClass> Lists;
}
