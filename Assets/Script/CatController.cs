using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour {
    public Rigidbody2D rigBody;
    public bool force = false,isPressing;
    public float minSpeed, maxSpeed, changeSpeed, decreseSpeed;
    
	// Use this for initialization
	void Start () {
        rigBody = GetComponent<Rigidbody2D>();
	}
	

	// Update is called once per frame
	void Update () {
        if (force)
        {
            force = false;
            rigBody.AddForce(new Vector2(0,5));
        }
        if(!isPressing)
            rigBody.velocity = Vector2.Lerp(rigBody.velocity, rigBody.velocity.normalized * minSpeed, decreseSpeed * Time.deltaTime);
        if (isPressing)
            isPressing = false;
	}
    public void SetSpeed(Vector2 sp)
    {
        rigBody.velocity =  Vector2.Lerp(rigBody.velocity, 
            rigBody.velocity .normalized * minSpeed+(maxSpeed - minSpeed) * sp ,changeSpeed * Time.deltaTime ) ;
        isPressing = true;
    }
    

}
