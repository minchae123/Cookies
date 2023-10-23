using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTouch : MiniGamePlayer
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            CheckCard(Input.mousePosition);
        }
    }

    private void CheckCard(Vector3 pos)
    {
        pos = mainCam.ScreenToWorldPoint(pos);
        RaycastHit2D hit = Physics2D.Raycast(pos, transform.forward, 15f);
        if(hit)
        {
            if(hit.transform.TryGetComponent(out RandomCard rand))
            {
                print("dd");
            }    
        }
    }

    public override void PlayerMove()
    {
        // 하는 거 없음
    }
}
