using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _OnKey : MonoBehaviour
{
    public string _key;

    private bool _isOn = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == _key)
        {
            _isOn = true;
            transform.parent.GetComponent<_endDoor>()._isKey();
        }
    }

    public bool _getKey()
    {
        return _isOn;
    }
}
