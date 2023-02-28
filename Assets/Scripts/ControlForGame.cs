using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlForGame : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public int score2;
    public Text sText;
    public Text savedText;
    void Start()
    {
        changeText();
        changeText2();
    }

    // Update is called once per frame
    void Update()
    {
        
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
        score = score + point;
        changeText();
        

    }

    public void AddPointSystem2(int points)
    {

        score2 = score2 + score;

        sText.text = savedText.text;
        changeText2();
        

    }

    public void addPointSystem3(int points)
    {
        score = 0;
        changeText();
    }

}
