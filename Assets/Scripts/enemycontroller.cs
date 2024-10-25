using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class enemycontroller : MonoBehaviour
{
    public GameObject rb;
    Vector3 moveDirection;

    public AudioSource audios;

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
        rb.transform.position = new Vector3(111.69f,11.65f,-49.46f);
        rb.transform.rotation = Quaternion.Euler(transform.localEulerAngles.x, -72, transform.localEulerAngles.z);
        audios = gameObject.GetComponent<AudioSource>();
        audios.Play();
    }

    public void moveEnemyRed()
    {
        rb.transform.position = new Vector3(108.38f, 11.27f, -82.97f);
        rb.transform.rotation = Quaternion.Euler(transform.localEulerAngles.x, 0, transform.localEulerAngles.z);
        audios = gameObject.GetComponent<AudioSource>();
        audios.Play();
    }
}
