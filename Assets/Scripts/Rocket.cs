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
   

    // Start is called before the first frame update
    void Start()
    {
        rocketRigidBody = GetComponent<Rigidbody2D>();
        // astro = GetComponent<SpriteRenderer>();
        // astro.enabled = true;
        // rocketMovement = startingPosition;
        astro.SetActive(false);
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
            //  other.transform.position = Vector2.MoveTowards(transform.position, gameObject.transform.position, 5f);
            Destroy(other.gameObject);

            //gameObject.transform.position;
            //gameObject.transform.position = startingPosition;
            // for (int i = 0; i > 0; i++) {
            // astro.enabled = false;
            astro.SetActive(true);
        }

        if (other.gameObject.tag == "planet")
        {

            astro.SetActive(false);
            
        }
        



    }

}  
