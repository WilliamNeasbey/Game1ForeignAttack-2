using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFollower : MonoBehaviour
{
    public GameObject Player;
    public float TargetDistance;
    public float AllowedDistance = 5;
    public GameObject NPCCharacter;
    public float FollowSpeed;
    public RaycastHit shot;

    void Update()
    {
        transform.LookAt(Player.transform);
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out shot))
        {
            TargetDistance = shot.distance;
            if(TargetDistance >= AllowedDistance)
            {
                FollowSpeed = 0.5f;
                NPCCharacter.GetComponent<Animation>().Play("running");
                transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, FollowSpeed);

            }
            else
            {
                AllowedDistance = 5;
                FollowSpeed = 0;
                NPCCharacter.GetComponent<Animation>().Play("idle");
            }
        }
    }
}
