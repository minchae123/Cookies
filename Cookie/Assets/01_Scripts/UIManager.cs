using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
	public static UIManager Instance;

	[SerializeField] private TextMeshProUGUI secondPerTxt;
	[SerializeField] private TextMeshProUGUI clickPerTxt;
	[SerializeField] private TextMeshProUGUI popularTxt;

	private void Awake()
	{
		if (Instance != null)
		{
			Debug.LogError("UIManager 오류");
		}
		Instance = this;
	}

	public void SetSecondPer(float per)
	{
		secondPerTxt.text = per.ToString() + "인기 /   초당";
	}

	public void SetClickPer(float per)
	{
		clickPerTxt.text = per.ToString() + "인기 / 클릭당";
	}

	public void ShowPopularity(float value)
	{
		popularTxt.text = value.ToString() + " 인기";
	}

	public void ShowPanel(GameObject panel)
	{
		panel.SetActive(true);
	}
	
	public void ClosePanel(GameObject panel)
	{
		panel.SetActive(false);
	}
}
