using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goaltrigger : MonoBehaviour
{
   
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            /*Debug.Log("Goallll");*/
            ScoreChange.onGoal?.Invoke();
        }
    }
}
