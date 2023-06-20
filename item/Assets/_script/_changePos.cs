using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _changePos : MonoBehaviour
{
    public string _dizuo;

    private bool _isTrue = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "dizuo" && other.name == _dizuo)
        {
            _isTrue = true;
            transform.parent.parent.gameObject.GetComponent<_LinkLine>()._isFinish();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "dizuo" && other.name == _dizuo)
        {
            _isTrue = false;
        }
    }

    public bool _getIs()
    {
        return _isTrue;
    }
}
