using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
	public static DataManager Instance;

	private ulong clickPrice;
	public ulong ClickPrice { get { return clickPrice; } set { clickPrice = value; } }
	private ulong secondPrice;
	public ulong SecondPrice { get { return secondPrice; } set { secondPrice = value; } }

	private void Awake()
	{
		if (Instance != null)
		{
			Debug.LogError("DataManager  ¿À·ù");
		}
		Instance = this;
	}
}
