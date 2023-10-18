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
        // �ƹ��͵� �� ��
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        CheckCollider otherPlayer = collision.gameObject.GetComponent<CheckCollider>();
        if (otherPlayer != null && otherPlayer.Level == Level)
        {
            print("��ü~");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
