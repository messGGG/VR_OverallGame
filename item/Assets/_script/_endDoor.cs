using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class _endDoor : MonoBehaviour
{
    public GameObject _win;
    public Material _mat;
    public GameObject _bigDoor1;
    public GameObject _bigDoor2;
    private int _mainTex;
    Vector2 v2 = new Vector2(0, 0);
    public List<Transform> _keyCube = new List<Transform>();

    private void Awake()
    {
        _bigDoor1 = transform.GetChild(0).gameObject;
        _bigDoor2 = transform.GetChild(1).gameObject;
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).tag == "KeyCube")
            {
                _keyCube.Add(transform.GetChild(i));
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _mainTex = Shader.PropertyToID("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        _ani();
    }

    public void _ani()
    {
        v2.x += 0.01f;
        _mat.SetTextureOffset(_mainTex, v2);
    }

    public void _openBigDoor()
    {
        _bigDoor1.transform.DOMoveZ(-6.0f, 4.0f);
        _bigDoor2.transform.DOMoveZ(0.2f, 4.0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            collision.transform.position = new Vector3(20,2,20);
            _win.SetActive(true);
        }
    }

    public void _isKey()
    {
        for(int i = 0; i < _keyCube.Count; i++)
        {
            Debug.Log(_keyCube[i].GetComponent<_OnKey>()._getKey() + "" + i);
            if (_keyCube[i].GetComponent<_OnKey>()._getKey())
            {
                Debug.Log(_keyCube[i].name + " true");
            }
            else
            {
                return;
            }
        }

        _openBigDoor();
        Debug.Log("Opeen Door");
    }

}
