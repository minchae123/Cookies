using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public User user;
    private string savePath;
    private string saveFileName = "/SaveFile.txt";

    private void Awake()
    {
        if(Instance != null)
		{
            Debug.LogError("GameManager  ����");
		}
        Instance = this;

        user = new User();
        savePath = Application.dataPath + "/SaveData/";

        if (!Directory.Exists(savePath))
        {
            Directory.CreateDirectory(savePath);
        }

        if (Directory.Exists(savePath))
        {
            Load();
        }
    }

	private void Start()
	{
        UIManager.Instance.SetClickPer(user.clickPer);
        UIManager.Instance.SetSecondPer(user.secondPer);
	}

	[ContextMenu("����")]
    public void Save()
    {
        string json = JsonUtility.ToJson(user);
        File.WriteAllText(savePath + saveFileName, json);
        //Debug.Log(json);
    }


    [ContextMenu("�ε�")]
    public void Load()
    {
        if (File.Exists(savePath + saveFileName))
        {
            string loadJson = File.ReadAllText(savePath + saveFileName);
            user = JsonUtility.FromJson<User>(loadJson);
            LoadSet();
            Debug.Log("�ε� ���� !");
        }
        else
        {
            Debug.Log("���� �ȴ� !!!");
        }
    }

    public void LoadSet()
	{
        UIManager.Instance.SetClickPer(user.clickPer);
        UIManager.Instance.SetSecondPer(user.secondPer);
        UIManager.Instance.ShowPopularity(user.popularity);
    }

    public void ScreenTouch()
    {
        user.popularity += user.clickLevel * 2;
        UIManager.Instance.ShowPopularity(user.popularity);
        Save();
	}
}
