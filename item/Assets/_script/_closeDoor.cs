using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class _closeDoor : MonoBehaviour
{
    public Transform _door;

    private void OnTriggerEnter(Collider other)
    {
        _door.DOMoveZ(-2.5f, 1.0f);
        Destroy(gameObject);
    }
}
