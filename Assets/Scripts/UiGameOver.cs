using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper ScoreKeeper;
    

    void Awake() {
        ScoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    void Start()
    {
        scoreText.text = "You Scored: \n" + ScoreKeeper.GetScore().ToString();
    }

}
