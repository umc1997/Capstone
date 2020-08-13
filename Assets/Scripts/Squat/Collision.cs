using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Floor") == 0)
        {
            this.transform.parent.GetComponent<CharacterSquat>().jumpCount = 0;
        }
        if (collision.gameObject.tag.CompareTo("DeadZone") == 0)
        {
            SquatGameManager.PlayerDie = true;
        }
        
    }
}
