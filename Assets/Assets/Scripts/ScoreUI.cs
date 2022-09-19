//ScoreUI.cs - Colin Klein
//September 19th - 2022
//This script determines how the score functions and what occurs when the coin disappears from the screen

using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Coin ScoreScript;
    private void Start()
    {
        ScoreScript = GameObject.Find("Coin").GetComponent<Coin>();

    }

    private void Update()
    {
        scoreText.text = "Score: " + ScoreScript.score;
    }

}
