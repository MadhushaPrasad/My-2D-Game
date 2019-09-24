using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    public Sprite HatSprite;
    public Sprite RocketSprite;
    private SpriteRenderer checkPointSpriteRenderer;
    public bool checkpointReached;
    // Start is called before the first frame update
    void Start()
    {
        checkPointSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            //what will happen when player enters the FallDetector zone
            checkPointSpriteRenderer.sprite = RocketSprite;
            checkpointReached = true;

        }
    }
}
