using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidPlayer : MiniGamePlayer
{
    private Vector3 lastPos;

    public override void PlayerMove()
    {
        Vector3 mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        transform.position += new Vector3(mousePos.x - lastPos.x, 0, 0);
        lastPos = mousePos;
    }

    private void Update()
    {
        if (AvoidManager.Instance.IsGameOver) return;
        if (Input.GetMouseButtonDown(0))
        {
            lastPos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0))
        {
            PlayerMove();
            PlayerRestrictScreen();
        }
    }
}
