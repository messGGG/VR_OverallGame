using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection2 : MonoBehaviour
{
    public string s;
    private bool flag = false;


    
    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag=="Player"&&!flag)
        {
            s = other.gameObject.name;
            flag = true;
     
        }

        if (other.gameObject.tag == "Player" && s.Equals(other.gameObject.name))
        {
            other.gameObject.transform.position = transform.position ; // 移动拼图到放置位置
            other.gameObject.transform.rotation =  transform.rotation;

        }
        
       
    }

}