using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSwitch : MonoBehaviour
{
    public List<Transform> characterList;
    public Button leftBtn, rightBtn;
    public static int idx = 0;

    bool updateUI = false;

    void Start()
    {
        UpdateUI();
        UpdateCharacter();
    }

    void Update()
    {
        if(updateUI)
        {
            updateUI = false;
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        leftBtn.interactable = idx > 0;
        rightBtn.interactable = idx < characterList.Count -1;
    }

    void UpdateCharacter()
    {
        for(int i=0; i<characterList.Count; i++)
        {
            characterList[i].gameObject.SetActive(i==idx);
        }
    }

    public void SwithCharacter(bool leftOrRight)
    {
        idx += leftOrRight ? -1 : 1;
        updateUI = true;
        UpdateCharacter();
    }
}
