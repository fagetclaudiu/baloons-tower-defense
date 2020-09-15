using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstantiateBubble : MonoBehaviour
{

    public GameObject bubblePrefab;
    private Ray ray; // The ray
    private RaycastHit hit; // What we hit

    void BubbleSpawn(){
        
        float xRandom = Random.Range(-Screen.width, Screen.width);

        GameObject newbubble = Instantiate(bubblePrefab, new Vector3(xRandom/2.5f, 0, 0), Quaternion.identity) as GameObject;
        newbubble.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);


    }


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("BubbleSpawn", 0.0f, 0.5f);
    }   

    // Update is called once per frame
    void Update()
    {


    }
    }


