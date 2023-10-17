using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string name; // 아이템 이름
    public int itemID; // 이이템 아이디
    public float appearPercent; // 아이템 나올 확률
    public Sprite itemSprite; // 아이템 스프라이트
}
[CreateAssetMenu(menuName = "SO/RandomItem")]   
public class RandomItemSO : ScriptableObject
{
    public List<Item> Items = new List<Item>();
}
