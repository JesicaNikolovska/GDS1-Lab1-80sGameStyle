using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public Rigidbody2D rocketRigidBody;
    private Vector2 rocketMovement;
    public float rocketSpeed;
    
    bool playermoving;
    // Start is called before the first frame update
    void Start()
    {
        rocketRigidBody = GetComponent<Rigidbody2D>();
    
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
    
}  
