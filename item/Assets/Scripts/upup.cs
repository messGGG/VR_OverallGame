using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upup : MonoBehaviour
{
    public float ySpeed = 5.5f;
    public float duration = 3f; // 增加y轴的时间
    public AudioSource audioSource;
    private bool isRaising = false;
    private bool falg = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"&&!falg)
        {
            StartCoroutine(RaiseCoroutine());
            falg = true;
        }
    }
    IEnumerator RaiseCoroutine()
    {
        audioSource.Play();
        isRaising = true;
        float elapsedTime = 0f;
        Vector3 originPos = transform.position;
        while (elapsedTime < duration)
        {
            yield return null; // 把控制权交给Unity，等待下一帧
            elapsedTime += Time.deltaTime;
            transform.position = Vector3.Lerp(originPos, originPos + new Vector3(0f, ySpeed, 0f), elapsedTime / duration);
        }
        isRaising = false;
    }
}
