using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {

    public CatController cat;
    public Vector2 speed;
    private void Start()
    {
        if(cat == null)
        {
            Debug.Log("cat not set ");
            enabled = false;
        }
    }
    private void Update()
    {
        speed.x = Input.GetAxis("Horizontal");
        speed.y = Input.GetAxis("Vertical");
        if ( speed.sqrMagnitude >= 0.5 )
        {
            cat.SetSpeed(speed);
        }
    }
}
