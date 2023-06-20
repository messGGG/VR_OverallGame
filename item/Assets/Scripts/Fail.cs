using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Fail : MonoBehaviour
{
    private CanvasGroup canvasGroup; 
    public Button back;
    public Button again;
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.DOFade(1, 2.0f);
 
    }

    public  void againout()
    {
       
        SceneManager.LoadScene("03");
        sucAndfail.count = 0;
        sucAndfail.time1 = 0;
    }

    public void backout()
    {
       
        SceneManager.LoadScene("02");
        sucAndfail.count = 0;
        sucAndfail.time1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
