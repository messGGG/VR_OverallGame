using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end1 : MonoBehaviour
{
    public GameObject obj;
    public static bool flag1 = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            obj.SetActive(true);
            flag1 = true;
        }
    }

}
