using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    public Rigidbody2D rocketRigidBody;
    private Vector2 rocketMovement;
    public float rocketSpeed;
    public Vector3 startingPosition;
    public GameObject rocket;
    bool playermoving;
    public GameObject astro;
    public int pointCollection;
    public int pointCollection2;
    public int pointCollection3;
    public ControlForGame theGameControl;
    public AstronautSpawning spawning;





    // Start is called before the first frame update
    void Start()
    {
        rocketRigidBody = GetComponent<Rigidbody2D>();
        // astro = GetComponent<SpriteRenderer>();
        // astro.enabled = true;
        // rocketMovement = startingPosition;
        astro.SetActive(false);

        theGameControl = GameObject.Find("Gamemanager").GetComponent<ControlForGame>();

}

    // Update is called once per frame
    void Update()
    {
        rocketMovement.y = Input.GetAxis("Vertical") * rocketSpeed;
        rocketMovement.x = Input.GetAxis("Horizontal") * rocketSpeed;

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Lab1-80s");
        }
        


    }
   
    private void FixedUpdate()
    {

          rocket.transform.position = transform.position + new Vector3(rocketMovement.x * Time.deltaTime, rocketMovement.y * Time.deltaTime,0);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "rock")
        {   
           
            gameObject.transform.position = startingPosition;
            astro.SetActive(false);
            SceneManager.LoadScene("GameOver");
        }

        if (other.gameObject.tag == "astro")
        {
            //if (pick up count system is lower then 3)
            //then destory. 

            //if (pick up count System == 3) 
            //DO NOT DESTORY
            // theGameControl.AddPointSystem(pointCollection);
            //     Destroy(other.gameObject);
            //  other.transform.position = Vector2.MoveTowards(transform.position, gameObject.transform.position, 5f);
            //gameObject.transform.position;
            //gameObject.transform.position = startingPosition;
            // for (int i = 0; i > 0; i++) {
            // astro.enabled = false;
            //     astro.SetActive(true);
            // if(pointCollection2 <= 3)
            // {
            //   theGameControl.addPointSystem4(pointCollection3);

            theGameControl.addpointSystem4(pointCollection3);

            // theGameControl.addpointSystem4();
            if (theGameControl.score3 < 4)
            {
             //heGameControl.addpointSystem4();
                Destroy(other.gameObject);
                astro.SetActive(true);
            }
           
           //f(theGameControl.score == 3)
           //
           //   Destroy(other.gameObject);
           //// astro.SetActive(true);
          //}
           
                
            
            
          //  }
        }

        if (other.gameObject.tag == "planet")
        {

            astro.SetActive(false);
           theGameControl.AddPointSystem2(pointCollection2);
            theGameControl.addPointSystem3(pointCollection);
            theGameControl.addPointSystem3(pointCollection3);


            //If pick up system == 1 
            //take points and restart pick up. 

            //If pick up system == 2 
            //take points and restart pick up.

            //If pick up system == 3 
            //take points and restart pick up.

        }

    }

    //Method for pick up system
    //assign astronauts a point value.
    //rocket can only hold 3 astronauts. 
    //if rocket reaches 3 can not hold more. 

}  
