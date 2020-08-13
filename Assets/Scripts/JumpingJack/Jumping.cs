using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    public float Jump = 3f;
    public bool key = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!JumpingJackGameManager.playerDie)
        {
            //키 입력 
            if (key || Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, Jump, 0);

                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            transform.Rotate(0, 0, 0);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("DeadZone") == 0)
        {
            //사망처리
            JumpingJackGameManager.playerDie = true;
           
        }
    }

    void getKey(string str)
    {
        if (str == "jump")
            key = true;
        else
            key = false;
    }
}
