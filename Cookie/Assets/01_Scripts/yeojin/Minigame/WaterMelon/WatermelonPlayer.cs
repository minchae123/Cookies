using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatermelonPlayer : MiniGamePlayer
{
    [SerializeField] private float speed = 5f;

    private Rigidbody2D rigid;
    private bool isCollision = false;
    private bool firstCollision = true;

    protected override void Awake()
    {
        base.Awake();
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    public override void PlayerMove()
    {
        Vector3 mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.y = transform.position.y;
        mousePos.z = 0;
        transform.position = Vector3.Slerp(transform.position, mousePos, speed * Time.deltaTime);
    }

    private void Update()
    {
        PlayerRestrictScreen();
        if (isCollision) return;

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
        //Debug.Log("무언가에 닿음");
        isCollision = true;
        if(firstCollision)
        {
            MergeSpawner.Instance.ReSpawn();
            firstCollision = false;
        }
    }
}
