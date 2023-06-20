using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class sucAndfail : MonoBehaviour
{
    public static int count = 0;
    public float time = 120f;
    public Text text;
    public bool suc = false;
    public bool flag = false;
    public static float time1;
    public GameObject panel;
    public GameObject panel2;
    void Start()
    {
        
        StartCoroutine("timecount");
    }

    void Update()
    {
      
            if (count == 5)
            {
                Debug.Log("all in");
                StopCoroutine("timecount");
                if (a.isEnter1 && b.isEnter2 && c.isEnter3 && d.isEnter4 && f.isEnter5)
                {
                    Debug.Log("suc");
                    StartCoroutine("Suc");
                }
                else
                {
                    StartCoroutine("Fail");
                }
            }
        
            if (time <= 0)
            {
                StopCoroutine("timecount");
                StartCoroutine("Fail");
            }


      
      
    }

    IEnumerator timecount()
    {
        while (time > 0)
        {
            time--;
            yield return new WaitForSeconds(1);
            text.text = "时间: " + time+"s";
        }
        
    }

    IEnumerator Suc()
    {
        time1 = time;
        yield return new WaitForSeconds(2);
        panel.SetActive(true);
    }
    IEnumerator Fail()
    {
        yield return new WaitForSeconds(2);
        panel2.SetActive(true);
    }
}
