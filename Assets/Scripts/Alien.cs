using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    bool IsItVisible = true;
    float timeManager;
    public float flashtime;
    public SpriteRenderer alienSprite;
    public PolygonCollider2D alienCollider;
    
    // Start is called before the first frame update
    void Start()
    {
        timeManager = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeManager = Time.deltaTime + timeManager;

        if(timeManager > flashtime)
        {
            timeManager = 0;
            alienSprite.enabled = !alienSprite.enabled;
            alienCollider.enabled = !alienCollider.enabled;
        }
    }
}
