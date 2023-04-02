using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BestScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TMP_Text>().text = "Best Score : " + Score.bestScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
