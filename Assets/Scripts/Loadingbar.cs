using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loadingbar : MonoBehaviour
{
	Slider	slider;
	float	sliderBar;
    
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    
    void Update()
    {
        if(slider.value < 3.0f)
        	slider.value += Time.deltaTime;
        else
        {
            if (Buttons.gameNum == 1)
                SceneManager.LoadScene("Squat");
            else if(Buttons.gameNum == 2)
                SceneManager.LoadScene("Lunge");
            else
                SceneManager.LoadScene("Jumping");
        }
    }
}
