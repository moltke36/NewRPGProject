using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class AIController : MonoBehaviour
{
    GameObject player;               // Reference to the player's position.
    NavMeshAgent nav;               // Reference to the nav mesh agent.
    NavMeshHit NavResult;
    Characters OwnerCharacter;
    Transform OwnerTranform;

    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player");
        nav = GetComponent<NavMeshAgent>();
        OwnerCharacter = GetComponent<Characters>();
        OwnerTranform = gameObject.transform;

    }


    void Update()
    {
        // If the enemy and the player have health left...
        // ... set the destination of the nav mesh agent to the player.
        nav.SetDestination(player.transform.position);
        OwnerCharacter.MoveX = nav.steeringTarget.normalized.x;
        OwnerCharacter.MoveZ = nav.steeringTarget.normalized.z;

        


        //if ((Vector3.Distance(player.transform.position, OwnerTranform.position))>= 25)
        //{
        //    print(Vector3.Distance(NavResult.position, OwnerTranform.position));
        //    if ((Mathf.Abs(player.transform.position.x - OwnerTranform.position.x)) >= Mathf.Abs(player.transform.position.z - OwnerTranform.position.z))
        //    {
        //        // Set SpeedX
        //        if (player.transform.position.x > OwnerTranform.position.x)
        //        {
        //            OwnerCharacter.MoveX = 1;
        //        }
        //        else
        //        {
        //            OwnerCharacter.MoveX = -1;
        //        }
        //    }
        //    else
        //    {
        //        // Set SpeedY
        //        if (player.transform.position.z > OwnerTranform.position.z)
        //        {
        //            OwnerCharacter.MoveZ = 1;
        //        }
        //        else
        //        {
        //            OwnerCharacter.MoveZ = -1;
        //        }
        //    }
        //}
        //else
        //{
        //     OwnerCharacter.MoveX = 0;
        //     OwnerCharacter.MoveZ = 0;
        //}

            

        
        // Otherwise...
        // ... disable the nav mesh agent.
        //nav.enabled = false;
    }
}