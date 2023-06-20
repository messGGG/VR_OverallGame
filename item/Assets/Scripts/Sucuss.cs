using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sucuss : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    private String grade ;
    public Text text;

   
    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.DOFade(1, 2.0f);
        float s = (120f - sucAndfail.time1);
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

        if (text != null)
            text.text = "成绩: " + grade;
    }

    public void nextout()
    {
       
        SceneManager.LoadScene("04");
        sucAndfail.count = 0;
        sucAndfail.time1 = 0;
    }

    public void backout()
    {
        
        SceneManager.LoadScene("02");
        sucAndfail.count = 0;
        sucAndfail.time1 = 0;
    }
    public  void nxt()
    {
        SceneManager.LoadScene("01");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
