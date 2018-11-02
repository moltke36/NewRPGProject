using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Var
    private Characters characterClass;

    // Use this for initialization
    void Start ()
    {
        characterClass = GetComponent<Characters>();
        if(!characterClass)
        {
            print("Missing characterClass");
            return;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        characterClass.MoveX = Input.GetAxis("Horizontal");
        characterClass.MoveZ = Input.GetAxis("Vertical");
    }
}
