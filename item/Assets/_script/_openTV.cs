using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _openTV : MonoBehaviour
{
    public GameObject _TV;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "[VRTK][AUTOGEN][BodyColliderContainer]")
        {
            Debug.Log("Open TV");
            _TV.SetActive(true);
        }
    }
}
