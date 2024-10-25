using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Interactor : MonoBehaviour
{
    public Transform InteractorSource1;
    public GameObject player;
    [SerializeField] Timeline t;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if ((InteractorSource1.transform.position - transform.position).magnitude < 5.0f)
            {
                player.transform.position = new Vector3(127f, 14.5f, -82f);
                t.jroom();
            }
        }
    }
}
