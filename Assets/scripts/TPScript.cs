using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPScript : MonoBehaviour
{
    //variables
    public Transform teleportTarget;
    public GameObject thePlayer;

    //on collision, transforms the players posotion to the target position
    void OnCollisionEnter2D(Collision2D col)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
    }
}

