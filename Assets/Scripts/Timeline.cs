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
        playermovement.movement = false;
        playercam.clampY = true;
    }

    void Update()
    {
        
    }
}
