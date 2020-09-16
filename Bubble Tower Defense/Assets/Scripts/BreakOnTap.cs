using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BreakOnTap : MonoBehaviour
{
    
    private int scoreInt = 0;
    public Text scoreTxt;
    

    public void Destroy(){
        Destroy(this.gameObject);
        
        scoreInt++;
        scoreTxt.text = "Score: " + scoreInt;
    }

    void Start() {
        scoreTxt = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     

}
