using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flyButton : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.CompareTo("Trap")==0 || collision.gameObject.tag.CompareTo("DeadZone") == 0)
        {
            //사망처리
            LungeGameManager.playerDie = true;
            SceneManager.LoadScene("End");
            Score.score = LungeGameManager.score;

            Application.ExternalCall("newScore", "Lunge", LungeGameManager.score);

            LungeGameManager.playerDie = false;
            LungeGameManager.score = 0;
        }
    }

}
