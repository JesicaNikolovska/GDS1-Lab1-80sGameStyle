using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketRotation : MonoBehaviour
    
{
    public Animator animationControl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animationControl.SetTrigger("GoLeft");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            animationControl.SetTrigger("GoRight");
        }
    }
}
