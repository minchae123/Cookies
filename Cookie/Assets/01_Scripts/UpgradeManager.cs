using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
	public static UpgradeManager Instance;

	private void Awake()
	{
		if(Instance != null)
		{
			Debug.LogError("UpgradeManager ¿À·ù");
		}
		Instance = this;
	}

	public void ClickLevelUp()
	{
		if(DataManager.Instance.ClickPrice < GameManager.Instance.user.popularity)
		{
			GameManager.Instance.user.clickLevel++;
			GameManager.Instance.user.popularity -= DataManager.Instance.ClickPrice;
			GameManager.Instance.LoadSet();
		}
		else
		{
			return;
		}
	}

	public void SecondLevelUp()
	{
		if (DataManager.Instance.SecondPrice < GameManager.Instance.user.popularity)
		{
			GameManager.Instance.user.secondLevel++;
			GameManager.Instance.user.popularity -= DataManager.Instance.SecondPrice;
			GameManager.Instance.LoadSet();
		}
	}
}
