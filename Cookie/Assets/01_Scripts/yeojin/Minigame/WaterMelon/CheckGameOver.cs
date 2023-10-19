using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGameOver : MonoBehaviour
{
    private bool isOver = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("감지1!감지!!");
        isOver = true;
        SpriteRenderer sr = collision.gameObject.GetComponent<SpriteRenderer>();
        StartCoroutine(OnTrigger(sr));
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isOver = false;
        StopAllCoroutines();
        collision.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        print("감지취소");
    }

    private IEnumerator OnTrigger(SpriteRenderer sr)
    {
        for (int i = 0; i < 3; i++)
        {
            sr.color = Color.red;
            yield return new WaitForSeconds(0.5f);
            sr.color = Color.white;
            yield return new WaitForSeconds(0.5f); 
        }
        CheckGameOverDelayed();
        yield return null;
    }

    private void CheckGameOverDelayed()
    {
        if (isOver)
        {
            MergeManager.Instance.SetGameOver();
            Destroy(this);
        }
    }
}
