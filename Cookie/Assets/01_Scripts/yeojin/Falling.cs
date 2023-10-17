using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Start()
    {
        speed = Random.Range(5f, 9f);
    }

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="Player")
        {
            if(this.gameObject.tag == "Good")
            {
                AvoidManager.Instance.AddScore();
                Debug.Log("Score");
            }
            else if(this.gameObject.tag == "Bad")
            {
                AvoidManager.Instance.GameOver();
                Debug.Log("GameOver. . .");
            }
        }
        Destroy(gameObject);
    }
}
