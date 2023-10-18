using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidSpawner : MonoBehaviour
{
    [SerializeField] private GameObject badFall;
    [SerializeField] private GameObject goodFall;

    private bool isGameOver = false;
    public bool IsGameOver => isGameOver;
    
    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        float time = Random.Range(0.3f, 2.5f);
        float xPos = Random.Range(-2f, 2f);
        bool rand = (Random.value > 0.5f);

        GameObject obj = rand ? Instantiate(badFall) : Instantiate(goodFall); // 50% ·£´ý»ý¼º
        obj.transform.position = new Vector3(xPos, transform.position.y, 0);
        
        yield return new WaitForSeconds(time);
        if(!AvoidManager.Instance.IsGameOver) StartCoroutine(Spawn());
    }
}
