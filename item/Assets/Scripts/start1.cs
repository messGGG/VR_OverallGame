using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class start1 : MonoBehaviour
{
    public AudioSource audioSource;

    public static float time22 = 0;

    public Text text;

    public float min = 0;

    private bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"&&!flag)
        {
            audioSource.Play();
            StartCoroutine("time3");
            flag = true;
        }
    }

    IEnumerator time3()
    {
        while (true)
        {
            time22++;
            yield return new WaitForSeconds(1);
            if (end1.flag1 )
            {
                break;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (time22 < 60)
        {
            text.text = "时间: " + time22 + "s";
        }
        else
        {
            min = time22 / 60;
            text.text = "时间: " +(int)min+"min"+ time22%60 + "s";
        }
    }
}
