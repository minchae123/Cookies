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
		GameManager.Instance.user.clickLevel++;
		GameManager.Instance.LoadSet();
	}

	public void SecondLevelUp()
	{
		GameManager.Instance.user.secondLevel++;
		GameManager.Instance.LoadSet();
	}
}
