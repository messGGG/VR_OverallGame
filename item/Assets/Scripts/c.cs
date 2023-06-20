using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c : MonoBehaviour
{
   
    static public bool isEnter3 = false;
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
            if (other.gameObject.name == "5")
            {
                isEnter3 = true;
            
            }
        }
    }

  
}