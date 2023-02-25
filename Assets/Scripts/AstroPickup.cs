using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroPickup : MonoBehaviour
{
  public GameObject astro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)|| Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (astro)
            {
                astro.transform.position = transform.position;
                astro.transform.parent = null;
            }
            else
            {
                //Collider 2D pickupAstro = Physics2D.OverlapCollide
            }
        }
    }
}
