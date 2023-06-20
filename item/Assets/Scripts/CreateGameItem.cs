using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CreateGameItem : MonoBehaviour
{
    public static CreateGameItem gameItems;
    public Material[] gameItemMaterial;
    private float angle;
    public GameObject goPrefab;
    public int index = 0;
    public bool flag = false;
    
    void Start()
    {
        gameItems = this;
        angle = 360.0f / gameItemMaterial.Length;
        for (int i = 0; i < gameItemMaterial.Length; i++)
        {
            
            GameObject gameItem = Instantiate(goPrefab, transform);
            gameItem.GetComponentInChildren<Renderer>().material = gameItemMaterial[i];
            
            gameItem.transform.position = new Vector3(gameItem.transform.position.x+ 24.65f,
                gameItem.transform.position.y, gameItem.transform.position.z );
            
            gameItem.transform.localEulerAngles = new Vector3(0, i * angle, 0);
        }
    }

    public void onBack()
    {
   
            index--;
            if (index < 0)
            {
                index = gameItemMaterial.Length - 1;
            }

         

            // 遍历所有子 Transform 并递归调用 RotateChildren
            
            
                RotateChildren(transform);
            
            //transform.DORotate(new Vector3(0,-index * angle ,0 ),0.5f);
   
       
        
    }

    public void onForWord()
    {


        index++;
        if (index >= gameItemMaterial.Length)
        {
            index = 0;
        }
        RotateChildren(transform);
        //transform.DORotate(new Vector3(0, -index * angle, 0), 0.5f);

    }
    
    
    void RotateChildren(Transform transform)
    {
        // 存储父物体的旋转
        Quaternion parentRotation = transform.rotation;

        // 将父物体的旋转归零
        transform.rotation = Quaternion.identity;

        // 遍历所有子 Transform，并旋转它们
        foreach (Transform child in transform)
        {
            child.Rotate(new Vector3(0, 120, 0),120);
        }

        // 恢复父物体的旋转
        transform.rotation = parentRotation;
    }





    void Update()
    {
        
    }
}