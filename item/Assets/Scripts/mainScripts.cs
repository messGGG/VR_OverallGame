using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI.Collections;
using Button = UnityEngine.UI.Button;

public class mainScripts : MonoBehaviour
{
    public  Button btnNext;
    public  Button btnBack;
    public  Button btnSelect;
  
    
    void Start()
    {
        btnNext = GameObject.Find("btnNext").GetComponent<Button>();
        btnBack = GameObject.Find("btnBack").GetComponent<Button>();
        btnSelect = GameObject.Find("btnSelect").GetComponent<Button>();
       
        btnNext.onClick.AddListener(OnBtnNextClick);
        btnBack.onClick.AddListener(OnBtnBackClick);
        btnSelect.onClick.AddListener(OnBtnSelectClick);
    }

    private void OnBtnSelectClick()
    {

        SceneManager.LoadScene(2 + CreateGameItem.gameItems.index);

    }

    private void OnBtnBackClick()
    {
        CreateGameItem.gameItems.onBack();
      
    }

    private void OnBtnNextClick()
    {
        CreateGameItem.gameItems.onForWord();
    
    }


    void Update()
    {
        
    }
}