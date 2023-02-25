using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public Rigidbody2D rocketRigidBody;
    private Vector2 rocketMovement;
    public float rocketSpeed;
    public Vector3 startingPosition;
    bool playermoving;
    // Start is called before the first frame update
    void Start()
    {
        rocketRigidBody = GetComponent<Rigidbody2D>();
       // rocketMovement = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        rocketMovement.y = Input.GetAxis("Vertical") * rocketSpeed;
        rocketMovement.x = Input.GetAxis("Horizontal") * rocketSpeed;
        


    }
   
    private void FixedUpdate()
    {

          transform.position = transform.position + new Vector3(rocketMovement.x * Time.deltaTime, rocketMovement.y * Time.deltaTime,0);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "rock")
        {   
           
            gameObject.transform.position = startingPosition;
        }

        if(other.gameObject.tag == "astro")
        {
          //  GetComponent
        }
    }

}  
