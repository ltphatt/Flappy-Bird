using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class Medal : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private Sprite noneMedal;
    [SerializeField] private Sprite bronzeMedal;
    [SerializeField] private Sprite silverMedal;
    [SerializeField] private Sprite goldMedal;

    Image medal;

    void Start()
    {
        medal = GetComponent<Image>();
        score = Score.instance.GetCurrentScore();
    }

    void Update()
    {
        ChangeMedal();
    }

    void ChangeMedal()
    {
        if (score < 10)
        {
            medal.sprite = noneMedal;
        }
        else if (score < 30)
        {
            medal.sprite = bronzeMedal;
        }
        else if (score < 50)
        {
            medal.sprite = silverMedal;
        }
        else
        {
            medal.sprite = goldMedal;
        }
    }
}
