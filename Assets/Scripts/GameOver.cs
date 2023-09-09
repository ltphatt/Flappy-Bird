using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI resultScoreText;
    [SerializeField] TextMeshProUGUI resultHighScoreText;

    void Start()
    {
        resultScoreText.text = Score.instance.GetCurrentScore().ToString();
        resultHighScoreText.text = Score.instance.GetHighScore().ToString();
    }
}
