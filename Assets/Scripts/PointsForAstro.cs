using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsForAstro : MonoBehaviour
{
    public Rigidbody2D astroRigidBody;
    public int pointCollection;
    public ControlForGame theGameControl;
    // Start is called before the first frame update
    void Start()
    {
        astroRigidBody = GetComponent<Rigidbody2D>();
        theGameControl = GameObject.Find("Gamemanager").GetComponent<ControlForGame>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
             theGameControl.AddPointSystem(pointCollection);

        }
        
    }


}

