using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BreakOnTap : MonoBehaviour
{



    public Text scoreTxt;
    static int scoreInt = 0;


    

    public void Destroy(){
        Destroy(this.gameObject);
      //  FinalScore.GetComponent<Score>().SetTheScore(scoreInt);
        
        scoreInt++;
        scoreTxt.text = "Score: " + scoreInt;
        
    }

    void Start() {
      //  FinalScore = GameObject.FindWithTag("Score");

        scoreTxt = GameObject.Find( "Score" ).GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     

}
