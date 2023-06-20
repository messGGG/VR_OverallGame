using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{
   
   static public bool isEnter1 = false;
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
            if (other.gameObject.name == "2")
            {
                isEnter1 = true;
                
            }
        }
    }

   
}