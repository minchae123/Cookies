using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private User user;
    private string savePath;
    private string saveFileName = "/SaveFile.txt";

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        user = new User();
        savePath = Application.dataPath + "/SaveData/";

        if (!Directory.Exists(savePath))
        {
            Directory.CreateDirectory(savePath);
        }
    }

	private void Start()
	{
        UIManager.Instance.SetClickPer(user.clickPer);
        UIManager.Instance.SetSecondPer(user.secondPer);
	}

	[ContextMenu("저장")]
    public void Save()
    {
        string json = JsonUtility.ToJson(user);
        File.WriteAllText(savePath + saveFileName, json);
        Debug.Log(json);
    }


    [ContextMenu("로드")]
    public void Load()
    {
        if (File.Exists(savePath + saveFileName))
        {
            string loadJson = File.ReadAllText(savePath + saveFileName);
            user = JsonUtility.FromJson<User>(loadJson);
            Debug.Log("로드 성공 !");
        }
        else
        {
            Debug.Log("저장 안댐 !!!");
        }
    }
}
