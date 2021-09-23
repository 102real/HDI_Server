using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine("SoundC1");

        }
    }


    IEnumerator SoundC1()
    {
        Debug.Log("시작"); 
        yield return new WaitForSeconds(4f);
        Debug.Log("2초 지남");
        yield return new WaitForSeconds(5f);
        Debug.Log("5초 지남");
    }
}