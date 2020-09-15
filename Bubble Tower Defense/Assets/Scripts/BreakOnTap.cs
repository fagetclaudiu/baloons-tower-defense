using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakOnTap : MonoBehaviour
{


    void distrugere(){
         Destroy(this.gameObject);
    }
    public int health = 1;

    // Update is called once per frame
    void Update()
    {

    if (Input.GetMouseButtonDown(0)){
    health = 0;
    }

    if (health == 0){
    distrugere();
    }
    }
}
