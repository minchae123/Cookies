using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string name; // ������ �̸�
    public int itemID; // ������ ���̵�
    public float appearPercent; // ������ ���� Ȯ��
    public Sprite itemSprite; // ������ ��������Ʈ
}
[CreateAssetMenu(menuName = "SO/RandomItem")]   
public class RandomItemSO : ScriptableObject
{
    public List<Item> Items = new List<Item>();
}
