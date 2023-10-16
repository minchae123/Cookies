using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{    
    private Camera mainCam;
    private bool isStart = false;

    private void Awake()
    {
        mainCam = Camera.main;
    }

    private void Start()
    {
        isStart = false; // Ŭ���� ��ŸƮ �ϰ�
    }

    private void Update()
    {
        if(Input.GetMouseButton(0)) // �÷��̾� �����̱�
        {
            Vector3 mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePos.x, transform.position.y, 0);
        }
    }
}
