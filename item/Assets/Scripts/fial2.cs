using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class fial2 : MonoBehaviour
{
    private CanvasGroup canvasGroup; 
 
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.DOFade(1, 2.0f);
 
    }

    public  void againout()
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