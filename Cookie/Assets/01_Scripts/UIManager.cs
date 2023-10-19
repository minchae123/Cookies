using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
	public static UIManager Instance;

	private void Awake()
	{
		if (Instance != null)
		{
			Debug.LogError("UIManager ����");
		}
		Instance = this;
	}

	[SerializeField] private TextMeshProUGUI secondPerTxt;
	[SerializeField] private TextMeshProUGUI clickPerTxt;
	[SerializeField] private TextMeshProUGUI popularTxt;

	public void SetSecondPer(float per)
	{
		secondPerTxt.text = per.ToString() + "�α� /   �ʴ�";
	}

	public void SetClickPer(float per)
	{
		clickPerTxt.text = per.ToString() + "�α� / Ŭ����";
	}

	public void ShowPopularity(float value)
	{
		popularTxt.text = value.ToString() + " �α�";
	}
}
