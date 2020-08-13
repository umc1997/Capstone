using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LungeGameManager : MonoBehaviour
{
    static public bool playerDie = false;
    public float trapTime = 1.1f;
    public float trapMin = -0.7f;
    public float trapMax = 0.7f;
    static public int score = 0;
    static public int bestScore = 0;
    public Text ScoreText;

    public GameObject trapPrefab;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(trapStart());
    }

    IEnumerator trapStart()
    {
        do
        {
            Instantiate(trapPrefab,
                new Vector3(4f, Random.Range(trapMin, trapMax), 0),
                Quaternion.Euler(new Vector3(0, 0, 0)));
            yield return new WaitForSeconds(trapTime);
        } while (!playerDie);
    }
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.ToString();
    }
}
