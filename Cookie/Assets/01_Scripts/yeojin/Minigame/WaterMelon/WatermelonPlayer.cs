using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatermelonPlayer : MiniGamePlayer
{
    [SerializeField] private float speed = 5f;
    private Rigidbody2D rigid;

    protected override void Awake()
    {
        base.Awake();
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        transform.position = new Vector3(0, 3.5f, 0);
    }
    public override void PlayerMove()
    {
        Vector3 mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        mousePos.y = 3.5f;
        // transform.position = mousePos; // 이 부분을 주석 처리하여 변경
        rigid.MovePosition(mousePos); // rigidbody를 통한 위치 변경으로 수정
    }

    private void Update()
    {
        PlayerRestrictScreen();
        if (Input.GetMouseButton(0))
        {
            PlayerMove();
        }
        if(Input.GetMouseButtonUp(0))
        {
            rigid.gravityScale = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        MergeSpawner.Instance.ReSpawn();
        Destroy(this);
    }
}
