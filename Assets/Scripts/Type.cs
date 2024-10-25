using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Type : MonoBehaviour
{
    public float delay = 0f;
    public string[] lines;
    private int index;

    public TextMeshProUGUI obj;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (obj.text == lines[index])
            {
                nextLine();
            }
            else
            {
                StopAllCoroutines();
                obj.text = lines[index];
            }
        }
        
    }

    public void runtext()
    {
        obj.text = string.Empty;
        index = 0;
        StartCoroutine(write());
    }

    // Update is called once per frame
    public IEnumerator write()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            obj.text += c;
            yield return new WaitForSeconds(delay);
        }
        yield return new WaitForSeconds(3f);
        nextLine();
    }

    void nextLine()
    {
        if (index < lines.Length -1)
        {
            index++;
            obj.text = string.Empty;
            StartCoroutine(write());
        }
        else
        {
            //gameObject.SetActive(false);
        }
    }
}
