using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuScore : MonoBehaviour
{
    public GameObject scoreTextHolder;

    private void Start()
    {
        if(ScoreManager.instance != null)
        {
            TMP_Text scoreText = scoreTextHolder.GetComponent<TMP_Text>();
            scoreText.text = $"High Score: {ScoreManager.instance.topPlayerName} : {ScoreManager.instance.highScore}";
        }
    }
}
