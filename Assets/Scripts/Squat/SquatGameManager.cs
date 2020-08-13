using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SquatGameManager : MonoBehaviour
{
    public static bool PlayerDie = false;
    public static int score = 0;
    public Text ScoreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerDie)
        {
            Application.ExternalCall("newScore", "Squat", score);

            PlayerDie = false;
            Score.score = score;
            score = 0;
            SceneManager.LoadScene("End");
        }
        else
        {
            ScoreText.text = score.ToString();
        }
    }
}
