using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public bool IsSpawnActive = false;

    private void Start()
    {
        StartCoroutine(Countdown(2));
    }

    private IEnumerator Countdown(float delay, int start = 2)
    {
        var wait = new WaitForSeconds(delay);

        for (int i = 0; i < start; i++)
        {
            if (i == 2)
            {
                IsSpawnActive = true;
            }
            yield return wait;
        }

        IsSpawnActive = false;
    }
}
