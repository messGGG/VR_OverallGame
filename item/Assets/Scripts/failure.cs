using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failure : MonoBehaviour
{
    public static bool flag12 = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.position = new Vector3(6, 2, 2);
            flag12 = true;
        }
    }
}
