using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreChange : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    int score=0;
    public static Action onGoal;
    public static Action onReset;
    
    private void OnEnable()
    {
        onGoal += Goal;
    }
    void Goal()
    {
        score += 1;
        scoreText.text = score.ToString();
        Invoke("InvokeOnReset", 1f);
    }
    void InvokeOnReset()
    {
        Debug.Log("Called");
        onReset?.Invoke();
    }
}
