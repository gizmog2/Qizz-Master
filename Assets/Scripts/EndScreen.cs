using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finaltScoreText;
    ScoreKeeper scoreKeeper;
    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();

    }

    public void ShowFinaleScore()
    {
        finaltScoreText.text = "Поздравляю! Ты прошел игру.\nТвой финальный счет: " + 
                                scoreKeeper.CalculateScore() + "%";
    }

}
