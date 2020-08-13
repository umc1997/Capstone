using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text ScoreTxt;

    void Start()
    {
        ScoreTxt.text = score.ToString();
    }

    void Update()
    {

    }
}
