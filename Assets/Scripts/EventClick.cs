using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EventClick : MonoBehaviour
{
    [SerializeField] Timeline t;

    public GameObject nail;
    public GameObject phone;
    Ray ray;
    RaycastHit hit;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
                if (hit.collider.gameObject == nail)
                {
                    t.stage2();
                }
                else if (hit.collider.gameObject == phone)
                {
                    StartCoroutine(t.die());
                }
        }
    }

}
