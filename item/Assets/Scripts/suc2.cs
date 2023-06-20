using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class suc2 : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    private String grade ;
    public Text text;

   
    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.DOFade(1, 2.0f);
        float s = start1.time22;
        if (s >= 60)
        {
            s %= 60f;
            grade = "1min" + s + "s";
        }
        else
        {
            grade =  s + "s";
        }
        Debug.Log("grade"+grade);
        text.text = "成绩: " + grade;
        
       
    }

    public void nextout()
    {
       
        SceneManager.LoadScene("04");
        start1.time22 = 0;
        failure.flag12 = false;
        end1.flag1 = false;
    }

    public void backout()
    {
        
        SceneManager.LoadScene("02");
        start1.time22 = 0;
        failure.flag12 = false;
        end1.flag1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}