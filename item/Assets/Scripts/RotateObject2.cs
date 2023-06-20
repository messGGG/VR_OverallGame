using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject2 : MonoBehaviour
{
    public float startAngle = -30f;
    public float endAngle = 30f;


    public float rotationSpeed = 100f;
    public float rotationTime = 2f;

    private void Start()
    {
        StartCoroutine(RotateObject1());

    }

    private IEnumerator RotateObject1()
    {
        while (true)
        {
            float t = 0f;
            while (t < rotationTime)
            {
                t += Time.deltaTime;
                float angle = Mathf.Lerp(startAngle, endAngle, t/rotationTime);
                transform.eulerAngles = new Vector3(angle, transform.eulerAngles.y, transform.eulerAngles.z);
                yield return null;
            }

            yield return null;
            t = 0f;
            while (t < rotationTime)
            {
                t += Time.deltaTime;
                float angle = Mathf.Lerp(endAngle, startAngle, t/rotationTime);
                transform.eulerAngles = new Vector3(angle, transform.eulerAngles.y, transform.eulerAngles.z);
                yield return null;
            }
        }
        
    }

}