using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b : MonoBehaviour
{
   
    static public bool isEnter2 = false;
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
            if (other.gameObject.name == "4")
            {
                isEnter2 = true;
                
            }
        }
    }

}