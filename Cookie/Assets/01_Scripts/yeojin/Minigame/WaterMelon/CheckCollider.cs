using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollider : MiniGamePlayer
{
    public int Level;

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
        CheckCollider otherPlayer = collision.gameObject.GetComponent<CheckCollider>();
        if (otherPlayer != null && otherPlayer.Level == Level)
        {
            print("합체~");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
