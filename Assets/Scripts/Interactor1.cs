using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Interactor1 : MonoBehaviour
{
    public Transform InteractorSource2;
    public GameObject player;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if ((InteractorSource2.transform.position - transform.position).magnitude < 5.0f)
            {
                SceneManager.LoadScene("stage1");
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
