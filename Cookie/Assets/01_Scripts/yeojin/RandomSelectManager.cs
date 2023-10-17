using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Linq;
using TMPro;
using UnityEngine.UI;

public class RandomSelectManager : MonoBehaviour
{
    [SerializeField] private RandomItemSO itemSO;
    [SerializeField] private TextMeshProUGUI itemText;

    [Header("Select Panel")]
    [SerializeField] private GameObject itemPanel;
    [SerializeField] private Button closeButton;
    [SerializeField] private Image panelItemSprite;
    [SerializeField] private TextMeshProUGUI panelItemText;
    
    [Header("UI")]
    [SerializeField] private GameObject selectButton;
    [SerializeField] private GameObject itemObj;

    private float[] itemWeights; // ������ ��� Ȯ��

    private void Start()
    {
        itemWeights = itemSO.Items.Select(i => i.appearPercent).ToArray(); // Ȯ��

        itemText.text = "��ٸ��� ��. . .";
        itemPanel.SetActive(false);
    }
        
    public void SelectButton()
    {
        SelectItem();
    }

    private void SelectItem()
    {
        int idx = GetRandomWeightIndex();

        itemText.text = $"{itemSO.Items[idx].name} ��÷!!";

        SpriteRenderer sr = itemObj.GetComponent<SpriteRenderer>(); 
        sr.sprite = itemSO.Items[idx].itemSprite;

        itemObj.SetActive(true);
        selectButton.SetActive(false);

        itemObj.transform.DOScale(2f, 0.7f).SetEase(Ease.OutQuad)
            .OnComplete(() =>
            {
                itemPanel.SetActive(true); // �г� ����
                panelItemText.text = itemText.text;
                panelItemSprite.sprite = sr.sprite;
                closeButton.onClick.AddListener(() =>
                {
                    itemPanel.SetActive(false); // �г��� ����
                    selectButton.SetActive(true);
                    itemObj.SetActive(false);

                    itemText.text = "��ٸ��� ��. . .";
                });
                itemObj.transform.DOScale(1f, 0.7f).SetEase(Ease.InExpo);
            });
        Debug.Log(itemSO.Items[idx].itemID);
    }

    private int GetRandomWeightIndex()
    {
        float sum = 0;
        for (int i = 0; i < itemWeights.Length; i++)
        {
            sum += itemWeights[i];
        }

        float rand = Random.Range(0, sum);
        float temp = 0;

        for (int i = 0; i < itemWeights.Length; i++)
        {
            if (rand >= temp && rand < temp + itemWeights[i])
            {
                return i;
            }
            else temp += itemWeights[i];
        }

        return 0;
    }
}
