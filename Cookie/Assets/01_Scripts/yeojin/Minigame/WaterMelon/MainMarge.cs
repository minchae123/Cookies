using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMarge : MiniGamePlayer
{
    [SerializeField] private MergeObjectSO mergeSO;
    public int Level;
    private SpriteRenderer sr;

    protected override void Awake()
    {
        base.Awake();
        sr = transform.Find("Sprite").GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        int rand = Random.Range(0, 1);
        sr.sprite = mergeSO.Lists[rand].objSprite;
        Level = rand;
    }

    private void Update()
    {
        PlayerRestrictScreen();
    }

    public override void PlayerMove()
    {
        // 아무것도 안 함
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        MainMarge otherPlayer = collision.gameObject.GetComponent<MainMarge>();
        if (otherPlayer != null && otherPlayer.Level == Level)
        {
            if (gameObject.GetInstanceID() < otherPlayer.gameObject.GetInstanceID()) // 둘중에 하나만 부서짐
            {
                print("합체~");
                Destroy(collision.gameObject);
                sr.sprite = mergeSO.Lists[++Level].objSprite;
                this.gameObject.transform.localScale 
                    = new Vector3(mergeSO.Lists[Level].scale, mergeSO.Lists[Level].scale, mergeSO.Lists[Level].scale);
            }
        }
    }
}
