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

    public AudioSource audios;

    float currentTime = 0f;
    float startingTime = 30f;

    public GameObject chains;
    public GameObject killer;
    public GameObject phone;
    public GameObject door1;
    public GameObject door2;
    public GameObject hostage;
    public TextMeshProUGUI obj;

    float y;
    string text;   

    void Start()
    {
        audios = gameObject.GetComponent<AudioSource>();
        audios.Play();
        stage1();
    }

    void Update()
    {
        if (currentTime <= 0)
        {
            StartCoroutine(die());
        }
        currentTime -= 1 * Time.deltaTime;


        if ((door1.transform.position - transform.position).magnitude < 2.0f)
        {
            obj.text = "Press E to go through the GREY door";
        }
        if ((door2.transform.position - transform.position).magnitude < 2.0f)
        {
            obj.text = "Press E to go through the RED door";
        }
        if ((hostage.transform.position - transform.position).magnitude < 2.0f)
        {
            obj.text = "Press E to go ESCAPE with the hostage";
        }

    }

    public IEnumerator die()
    {
        enemy.moveEnemy();
        yield return new WaitForSeconds(2f);
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("gameover");
        Cursor.lockState = CursorLockMode.None;
    }

    public IEnumerator die2()
    {
        enemy.moveEnemyRed();
        yield return new WaitForSeconds(2f);
        Cursor.lockState = CursorLockMode.None;
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
        Destroy(phone);
        playermovement.movementoff = false;
        playercam.clampY = false;

        type.lines[0] = "Im Free!";
        type.lines[1] = "This is my chance to escape";
        type.lines[2] = "Maybe one of theese doors is the way out...";

        type.runtext();
    }

    public void jroom()
    {

        type.lines[0] = "HOSTAGE: NO DONT LEAVE STAY WITH ME!!";
        type.lines[1] = "Press E to put the hostage out of their misery";
        type.lines[2] = "Or stay and you both die...";

        type.runtext();
    }

    public IEnumerator rdroom()
    {
        type.lines[0] = "Oh my god...";
        type.lines[1] = " ";
        type.lines[2] = " ";

        type.runtext();
        yield return new WaitForSeconds(1f);
        Destroy(killer);
        yield return new WaitForSeconds(1f);
        StartCoroutine(die2());
    }
}
