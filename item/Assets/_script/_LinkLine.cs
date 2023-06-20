using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class _LinkLine : MonoBehaviour
{
    public List<Transform> _pointPos = new List<Transform>();
    public List<int> _order = new List<int>();
    public GameObject _door;
    

    private void Awake()
    {
        _findChild(gameObject);
    }

    private void _findChild(GameObject child)
    {
        for(int i = 0; i < child.transform.childCount; i++)
        {
            if(child.transform.GetChild(i).childCount > 0)
            {
                _findChild(child.transform.GetChild(i).gameObject);
            }

            if(child.transform.GetChild(i).tag == "LinkPoint")
            {
                _pointPos.Add(child.transform.GetChild(i));
            }
        }
    }

    public Vector3[] _getPoint()
    {
        Vector3[] _pos = new Vector3[_order.Count];
        for(int i = 0; i < _order.Count; i++)
        {
            _pos[i] =_pointPos[_order[i] - 1].position - transform.position;
        }
        return _pos;
    }

    public void _isFinish()
    {
        for(int i = 0; i < _pointPos.Count; i++)
        {
            if (_pointPos[i].gameObject.GetComponent<_changePos>()._getIs())
            {
                
            }

            else
            {
                Debug.Log(_pointPos[i].name + ":false");
                return;
            }
        }

        Debug.Log("连线完成");
        StartCoroutine(_opeenDoor());
        GetComponent<VolumetricLines.VolumetricMultiLineBehavior>().LineColor = Color.green;
    }

    IEnumerator _opeenDoor()
    {
        yield return new WaitForSeconds(1.0f);
        if(_door.name == "door01")
        {
            _door.transform.DOMoveZ(-7, 4.0f);
        }
        else if(_door.name == "door02")
        {
            _door.transform.DOMoveZ(0, 5.0f);
        }

        else if(_door.name == "WhileKey")
        {
            _door.SetActive(true);
        }

        yield return null;
    }
}
