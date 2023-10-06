using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopKeyLog : MonoBehaviour
{
    private int lastHitKey;
    public List<int> loggedKeys;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            lastHitKey = 1;
            Debug.Log("1");
            loggedKeys.Add(lastHitKey);

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            lastHitKey = 2;
            Debug.Log("2");
            loggedKeys.Add(lastHitKey);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            lastHitKey = 3;
            Debug.Log("3");
            loggedKeys.Add(lastHitKey);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            lastHitKey = 4;
            Debug.Log("4");
            loggedKeys.Add(lastHitKey);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            lastHitKey = 5;
            Debug.Log("5");
            loggedKeys.Add(lastHitKey);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            lastHitKey = 6;
            Debug.Log("6");
            loggedKeys.Add(lastHitKey);
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            lastHitKey = 7;
            Debug.Log("7");
            loggedKeys.Add(lastHitKey);
        }
        
        if (Input.GetKeyDown(KeyCode.I))
        {
            lastHitKey = 8;
            loggedKeys.Add(lastHitKey);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            lastHitKey = 9;
            loggedKeys.Add(lastHitKey);
        }

    }
}
