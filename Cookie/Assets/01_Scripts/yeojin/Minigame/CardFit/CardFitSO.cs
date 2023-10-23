using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]
public class CardClass
{
    public Sprite cardSprite;
}
[CreateAssetMenu(menuName = "SO/MiniGame/CardFit/Card")]
public class CardFitSO : ScriptableObject
{
    public List<CardClass> Lists;
}
