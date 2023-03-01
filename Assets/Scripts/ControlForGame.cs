using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ControlForGame : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public int score2;
    public int score3;
    public Text sText;
    public Text savedText;
    public GameObject astroMan;
   
   
    void Start()
    {
        changeText();
        changeText2();
      
    }

    // Update is called once per frame
    void Update()
    {   
      //score3 = score3 + score;
    }

    void changeText()
    {
        sText.text = score.ToString();
    }
    
    void changeText2()
    {
        savedText.text = score2.ToString();
    }

    

    public void AddPointSystem(int point)
    {

        

      if (score <=2)
       //
        //oint = 1;
         //  if(point == 1)
            {
                score = score + point;
            
                changeText();
            }
            
       // }

       
       

        





    }

    public void AddPointSystem2(int points)
    {

        score2 = score + score2;

        sText.text = savedText.text;
        changeText2();
        if(score2 >= 5)
        {
            SceneManager.LoadScene("YouWin");
        }
        

    }

    public void addPointSystem3(int points)
    {
        score = 0;
        score3 = 0;
        changeText();
       
    }

    public void addpointSystem4(int point)
    {
     // score3 = 2;
        
        if(score3 > 4)
        {
            score3 =3;
        }
        //score3 = point++;
        //score3 += score;
    // score3 = score + point;
      //score3 = score++;
   score3++;
    }


    


}
