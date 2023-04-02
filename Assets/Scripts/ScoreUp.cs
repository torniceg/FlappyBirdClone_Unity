using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D col)
    {
        Score.score++;
    }
    
}
