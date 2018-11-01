using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Characters
{

    //Var
    public float speed;
    public GUIText textOutput;

    // Use this for initialization
    void Start ()
    {
     
    }
	
	// Update is called once per frame
	void Update ()
    {
        Movement();
    }

    void bindkey()
    {

    }

    void Movement()
    {
        float MoveX = Input.GetAxis("Horizontal");
        float MoveZ = Input.GetAxis("Vertical");

        float xDeltaPos = MoveX * speed;
        float zDeltaPos = MoveZ * speed;

        transform.Translate(new Vector3(xDeltaPos, 0, zDeltaPos));
        textOutput.text = "Horizontal Value Returned: " + xDeltaPos.ToString("F2") + "\nVertical Value Returned: " + zDeltaPos.ToString("F2");
    }
}
