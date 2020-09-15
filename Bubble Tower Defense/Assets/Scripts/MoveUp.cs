using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{

    public InstantiateBubble insBubRef;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("SpeedUP", 0.0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * 1 * Time.deltaTime);

    }
}
