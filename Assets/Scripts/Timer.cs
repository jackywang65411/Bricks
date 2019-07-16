using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{


    //計時器
    public bool StartCount;

    public float timer;

    public bool Switch;

    public int SwitchCase;

    public float WaitSecond;

    void Start()
    {

    }
    void Update()
    {
        /*if (StartCount)
        {
            timer -= Time.deltaTime;
            Debug.Log(timer);
            if (timer <= 0)
            {
                Switch = true;
                timer = 0;
                StartCount = false;
            }
        }*/

        if (StartCount)
        {
            StartCoroutine(Counter(SwitchCase , WaitSecond));
        }
    }

    IEnumerator Counter(int Num , float Second)
    {
        yield return new WaitForSeconds(Second);
        //Switch = true;
        //StartCount = false;
        //Debug.Log("2");

        switch(Num)
        {
            case 1:
                Debug.Log("A");
                break;
            case 2:
                Debug.Log("B");
                break;
            case 3:
                Debug.Log("C");
                break;
        }
    }
}
