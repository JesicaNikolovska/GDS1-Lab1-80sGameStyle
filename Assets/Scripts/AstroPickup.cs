using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroPickup : MonoBehaviour
{
      private Vector2 rocketMovement;
    public float rocketSpeed;
    public Vector3 startingPosition;
    public GameObject rocket;
    bool playermoving;
  //  private SpriteRenderer astro;
    public GameObject astro;
    // Start is called before the first frame update
    void Start()
    {
        
       // astro = GetComponent<SpriteRenderer>();
       // astro.enabled = true;
        // rocketMovement = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //rocketMovement.y = Input.GetAxis("Vertical") * rocketSpeed;
      //  rocketMovement.x = Input.GetAxis("Horizontal") * rocketSpeed;





    }

    private void FixedUpdate()
    {

      //  rocket.transform.position = transform.position + new Vector3(rocketMovement.x * Time.deltaTime, rocketMovement.y * Time.deltaTime, 0);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "planet")
        {

            astro.SetActive(false);
        }

       // if (other.gameObject.tag == "astro")
     //   {
    //        other.transform.position = Vector2.MoveTowards(transform.position, gameObject.transform.position, 5f);
            //  Destroy(other.gameObject);

            //gameObject.transform.position;
            //gameObject.transform.position = startingPosition;
            // for (int i = 0; i > 0; i++) {
     //       astro.enabled = false;

     //   }



    }

}
