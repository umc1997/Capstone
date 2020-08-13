using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JumpingJackGameManager : MonoBehaviour
{
    static public bool playerDie = false;
    static public float currentHeight = 0;
    static public float bestHeight = 0;
    static public int bestHeightInt = 0;
    public Text ScoreText;
    int index = CharacterSwitch.idx;

    // Start is called before the first frame update
    void Start()
    {


    }
    // Update is called once per frame

    void Update()
    {
        if (playerDie == true)
        {
            SceneManager.LoadScene("End");
            JumpingJackGameManager.playerDie = false;
            Score.score = JumpingJackGameManager.bestHeightInt;

            Application.ExternalCall("newScore", "JumpingJack", JumpingJackGameManager.bestHeightInt);

            JumpingJackGameManager.bestHeightInt = 0;
            JumpingJackGameManager.bestHeight = 0;
            JumpingJackGameManager.currentHeight = 0;
        }
        else
        {
            currentHeight = GameObject.Find("Character").transform.GetChild(index).transform.position.y;
            bestHeight = (bestHeight >= currentHeight) ? bestHeight : currentHeight;
            bestHeightInt = (int)bestHeight;
            ScoreText.text = bestHeightInt.ToString();
        }
    }
}
