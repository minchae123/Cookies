using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MiniGamePlayer : MonoBehaviour
{
    [HideInInspector] public Camera mainCam;
    protected virtual void Awake()
    {
        mainCam = Camera.main;
    }

    public abstract void PlayerMove();
    public void PlayerRestrictScreen()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -2.3f, 2.3f);
        transform.position = pos;
    }
}
