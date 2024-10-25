using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Interactor2 : MonoBehaviour
{
    public Transform InteractorSource2;
    public GameObject player;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if ((InteractorSource2.transform.position - player.transform.position).magnitude < 5.0f)
            {
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("win");
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
}
