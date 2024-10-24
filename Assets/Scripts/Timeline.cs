using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeline : MonoBehaviour
{
    [SerializeField] PlayerMovement playermovement;
    [SerializeField] PlayerCam playercam;

    float y;

    void Start()
    {
        playermovement.movement = true;
        playercam.clampY = false;
    }

    void Update()
    {
        
    }
}
