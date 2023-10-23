using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCard : MonoBehaviour
{
    [SerializeField] private CardFitSO cardSO;
    private SpriteRenderer cardSprite;
    public int cardID;

    private void Awake()
    {
        cardSprite = transform.Find("CardImage").GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        print(cardSO.Lists.Count);
        
        int rand = Random.Range(0, cardSO.Lists.Count);
        cardSprite.sprite = cardSO.Lists[rand].cardSprite;
        cardID = rand;
    }
}
