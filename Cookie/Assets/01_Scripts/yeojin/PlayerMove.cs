using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 lastPos;

    private void Awake()
    {
        mainCam = Camera.main;
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
            Vector3 mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
            transform.position += new Vector3(mousePos.x - lastPos.x, 0, 0);
            lastPos = mousePos;
        }
    }
}
