using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Timeline : MonoBehaviour
{
    [SerializeField] PlayerMovement playermovement;
    [SerializeField] PlayerCam playercam;
    [SerializeField] Type type;
    [SerializeField] enemycontroller enemy;

    float currentTime = 0f;
    float startingTime = 30f;

    public GameObject chains;
    public GameObject door1;
    public GameObject door2;
    public GameObject hostage;
    public TextMeshProUGUI obj;

    float y;
    string text;   

    void Start()
    {
        stage1();
    }

    void Update()
    {
        if (currentTime <= 0)
        {
            StartCoroutine(die());
        }
        currentTime -= 1 * Time.deltaTime;


        if ((door1.transform.position - transform.position).magnitude < 5.0f)
        {
            obj.text = "Press E to go through the GREY door";
        }
        if ((door2.transform.position - transform.position).magnitude < 5.0f)
        {
            obj.text = "Press E to go through the RED door";
        }
        if ((hostage.transform.position - transform.position).magnitude < 5.0f)
        {
            obj.text = "Press E to go ESCAPE with the hostage";
        }

    }

    public IEnumerator die()
    {
        enemy.moveEnemy();
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("gameover");
        Cursor.lockState = CursorLockMode.None;
    }


    public void stage1()
    {
        currentTime = startingTime;

        type.lines[0] = "WHAT!! WHY AM I IN CHAINED TO THE WALL??";
        type.lines[1] = "I must find something I can use to free myself";
        type.lines[2] = "Maybe there is somthing close by I can reach...";

        type.runtext();

        playermovement.movementoff = true;
        playercam.clampY = true;

    }

    public void stage2()
    {
        Destroy(chains);
        playermovement.movementoff = false;
        playercam.clampY = false;

        type.lines[0] = "Im Free!";
        type.lines[1] = "I must find something I can use to free myself";
        type.lines[2] = "Maybe there is somthing close by I can reach...";

        type.runtext();
    }
}
