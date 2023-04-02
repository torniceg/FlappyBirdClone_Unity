using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int bestScore = 0;
    private TMP_Text _scoreText;

    // Start is called before the first frame update
    void Start()
    {
        _scoreText = GetComponent<TMP_Text>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = score.ToString();
    }
}