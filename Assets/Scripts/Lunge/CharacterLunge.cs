using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class CharacterLunge : MonoBehaviour
{
    public List<Transform> characterList;
    int idx = CharacterSwitch.idx;
    public float Jump = 2f;
    public bool key = false;

    // Start is called before the first frame update
    void Start()
    {
        characterList[idx].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!LungeGameManager.playerDie)
        {
            if (key || Input.GetMouseButtonDown(0))
            {
                characterList[idx].gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, Jump, 0);
                transform.rotation = Quaternion.Euler(0, 0, 0);
                key = false;
            }
            transform.Rotate(0, 0, 0);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Trap") == 0)
        {
            //사망처리
            LungeGameManager.playerDie = true;
            Score.score = LungeGameManager.score;
            SceneManager.LoadScene("End");
            LungeGameManager.playerDie = false;
            LungeGameManager.score = 0;
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
