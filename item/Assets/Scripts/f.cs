using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f : MonoBehaviour
{
    static public bool isEnter5 = false;
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
            if (other.gameObject.name == "8")
            {
                isEnter5 = true;
              
            
            }
        }
    }
}
