using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AstronautSpawning : MonoBehaviour
{
  
    public GameObject astroSpawn;
    public Vector3 AstroPositioning;
    public Vector3 minPos;
    public Vector3 MaxPos;
  

    // Start is called before the first frame update
    void Start()
    {
        //  Instantiate(astroSpawn);
        //Vector3 randPos = new Vector3(Random.Range(minPos.x, MaxPos.x), Random.Range(minPos.y, MaxPos.y), Random.Range(minPos.z, MaxPos.z));
        // Vector3 pos = randPos;
        spawning();
    
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void spawning()
    {
        for (int i = 1; i < 6; i++)
        {
            Vector3 randPos = new Vector3(Random.Range(minPos.x, MaxPos.x), Random.Range(minPos.y, MaxPos.y), Random.Range(minPos.z, MaxPos.z));
            GameObject astro = Instantiate(astroSpawn, randPos, Quaternion.identity);
            
        }
    }



    
    }
