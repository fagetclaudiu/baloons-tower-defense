using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstantiateBubble : MonoBehaviour
{


    protected static float Hspeed = 200f;
    public GameObject bubblePrefab;
    public GameObject towerPrefab;


    void BubbleSpawn(){
        
        float xRandom = Random.Range(-Screen.width, Screen.width);

        GameObject newbubble = Instantiate(bubblePrefab, new Vector3(xRandom/2.5f, 0, 0), Quaternion.identity) as GameObject;
        newbubble.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);


         }

    void SpeedUp(){
        Hspeed += 100f;
        Debug.Log("Hspeed este acum: " + Hspeed);
    }


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("BubbleSpawn", 0.0f, 0.6f);
        InvokeRepeating ("SpeedUp", 5f, 5f);
        GameObject newTowerPrefab = Instantiate(towerPrefab, new Vector2(0,-450), Quaternion.identity) as GameObject;
        newTowerPrefab.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
    }   

    // Update is called once per frame
    void Update()
    {




    }

}


