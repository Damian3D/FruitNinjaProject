using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{

    string helloMessage = "Hello World";
    int score = 10;
    public Text currentScore;

    public Sprite[] foodSprites;

    int[] scores = {10, 9, 5, 40, 60 };

    // Start is called before the first frame update
    void Start()
    {
        spawnSprites();
    }

    void spawnSprites()
    {
        foreach (Sprite currentSprite in foodSprites)
        {
            GameObject food = new GameObject("item", typeof(SpriteRenderer));
            food.GetComponent<SpriteRenderer>().sprite = currentSprite;
            food.transform.localScale = new Vector3(0.2f, 0.2f);
            food.transform.position = new Vector3(0, 2);

            food.AddComponent<Rigidbody2D>();
            food.AddComponent<CircleCollider2D>();
        }
    }

    void updateScoreTextInGame()
    {
        currentScore.text = "Score" + score;
    }

    void printingArrayAtIndex()
    {
        Debug.Log(scores[0]);
        Debug.Log(scores[1]);
    }

    void printingMessages()
    {
        Debug.Log(helloMessage);
        Debug.Log(score);
    }

    void loopingAroundAnArrayUisngIndex()
    {
        for (int index = 0; index < scores.Length; index++)
        {
            Debug.Log(scores[index]);
        }
    }

    void loopingArrayEasierMethod()
    {
        foreach (int score in scores)
        {
            Debug.Log("Score" + score);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            spawnSprites();
        }
    }
}
