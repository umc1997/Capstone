using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform PlayerTransform;
    int index = CharacterSwitch.idx;
    // Start is called before the first frame update
    void Start()
    {
        //idx = GameObject.Find("Character").GetComponent<CharacterSwitch>().idx;
        //Debug.Log(idx);

        PlayerTransform = GameObject.Find("Character").transform.GetChild(index).transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerTransform.position.y>=transform.position.y)
        {
            transform.position = Vector3.Lerp(transform.position, PlayerTransform.position, 2f * Time.deltaTime);
            transform.Translate(0, 0, -1);
        }
    }
}
