using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public static int gameNum;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadHome()
    {
        SceneManager.LoadScene("Home");
    }

    public void LoadMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void LoadGameSelect()
    {
        SceneManager.LoadScene("SelectGames");
    }

    public void LoadSquat()
    {
        gameNum = 1;
        Application.ExternalCall("selectedGame", gameNum);
        //SceneManager.LoadScene("Squat");
        SceneManager.LoadScene("Loading");
    }

    public void LoadLunge()
    {
        gameNum = 2;
        Application.ExternalCall("selectedGame", gameNum);
        //SceneManager.LoadScene("Lunge");
        SceneManager.LoadScene("Loading");
    }

    public void LoadJumpingJack()
    {
        gameNum = 3;
        Application.ExternalCall("selectedGame", gameNum);
        //SceneManager.LoadScene("Jumping");
        SceneManager.LoadScene("Loading");
    }

    public void LoadGameToReStart()
    {
        if (gameNum == 1)
            LoadSquat();
        else if (gameNum == 2)
            LoadLunge();
        else if (gameNum == 3)
            LoadJumpingJack();
    }

    public void onlogin()
    {
        Application.ExternalCall("onlogin");
    }
}
