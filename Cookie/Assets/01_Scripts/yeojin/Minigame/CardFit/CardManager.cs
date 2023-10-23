using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public static CardManager Instacne;
    [SerializeField] private GameObject cardPref;

    private void Awake()
    {
        if (Instacne != null) print("카드매니저오류");
        Instacne = this;
    }

    private void Start()
    {
        for(int i=0;i<5;i++)
        {
            Instantiate(cardPref);
        }
    }
}
