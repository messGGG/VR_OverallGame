using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d : MonoBehaviour
{
   
    static public bool isEnter4 = false;
    private bool flag = false;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!flag)
            {
                sucAndfail.count++;
                flag = true;
            }
            if (other.gameObject.name == "6")
            {
                isEnter4 = true;
         
            }
        }
        // 判断进入碰撞器的是否为物体
        
    }

   
}