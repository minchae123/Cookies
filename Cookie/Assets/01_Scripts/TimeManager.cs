using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
	private void Start()
	{
		StartCoroutine(PlusSecondPerPopularity());
	}

	IEnumerator PlusSecondPerPopularity()
	{
		while(true)
		{
			GameManager.Instance.SecondPer();
			yield return new WaitForSeconds(1);
		}
	}
}
