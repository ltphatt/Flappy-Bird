using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.Unity.VisualStudio.Editor;

public class GameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI resultScoreText;
    [SerializeField] TextMeshProUGUI resultHighScoreText;
    [SerializeField] Image medal;
    [SerializeField] List<Image> medals;

    void Start()
    {
        resultScoreText.text = Score.instance.GetCurrentScore().ToString();
        resultHighScoreText.text = Score.instance.GetHighScore().ToString();
    }

    void Update()
    {

    }

    void ChangeMedal()
    {

    }
}
