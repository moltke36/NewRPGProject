using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour {


    public float speed;
    public float MoveX, MoveZ;

    public Animator animator;


    public Characters()
    {
        //int = CharacterTexture.height
        //var vertices: Vector3[] = new Vector3[4];
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float xDeltaPos = MoveX * speed * Time.deltaTime;
        float zDeltaPos = MoveZ * speed * Time.deltaTime;

        if (Mathf.Abs(MoveZ) < Mathf.Abs(MoveX))
        {
            if (MoveX > 0)
            {
                animator.SetInteger("Direction", 3);
                //print(animator.GetInteger("Direction"));
            }
            else if (MoveX < 0)
            {
                animator.SetInteger("Direction", 1);
                //print(animator.GetInteger("Direction"));
            }
        }
        else
        {
        
            if (MoveZ > 0)
            {
                animator.SetInteger("Direction", 2);
            }
            else if (MoveZ < 0)
            {
                animator.SetInteger("Direction", 0);
                //print(animator.GetInteger("Direction"));
            }
        }

        transform.Translate(new Vector3(xDeltaPos, 0, zDeltaPos));
    }
}
