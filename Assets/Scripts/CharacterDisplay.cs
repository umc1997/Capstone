using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDisplay : MonoBehaviour
{
	public List<Transform> characterList;
	int idx;

    void Start()
    {
        display();
    }

    void Update()
    {
        display();
    }

    void display()
    {
    	idx = CharacterSwitch.idx;
    	for(int i=0; i<characterList.Count; i++)
    		characterList[i].gameObject.SetActive(i==idx);
    }
}
