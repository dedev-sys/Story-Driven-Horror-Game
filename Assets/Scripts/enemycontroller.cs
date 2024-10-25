using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class enemycontroller : MonoBehaviour
{
    public GameObject rb;
    Vector3 moveDirection;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
    }

    public void moveEnemy()
    {
        rb.transform.position = new Vector3(109.54f,11.65f,-50);
    }
}
