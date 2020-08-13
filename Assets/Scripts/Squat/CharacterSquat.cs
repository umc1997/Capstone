using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class CharacterSquat: MonoBehaviour
{
    public List<Transform> characterList;
    int idx = CharacterSwitch.idx;
    public float jump = 6f;
    //public float jump2 = 10f;
    public int key;
    public int jumpCount = 0;

    void Start()
    {
        characterList[idx].gameObject.SetActive(true);
    }

    void Update()
    {
        
        if (!SquatGameManager.PlayerDie)
        {
            // 키입력
            if (key == 1 || Input.GetMouseButtonDown(0))
            {
                if(jumpCount == 0)
                {
                    characterList[idx].gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump, 0);
                    jumpCount = 1;
                    key = 0;
                }
            }
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Floor") == 0)
        {
            jumpCount = 0;
        }
        if (collision.gameObject.tag == "DeadZone")
        {
            SquatGameManager.PlayerDie = true;
        }
    }
    void getKey(string str)
    {
        if (str == "jump")
            key = 1;
        else
            key = 0;
    }
}
