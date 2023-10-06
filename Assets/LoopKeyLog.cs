using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopKeyLog : MonoBehaviour
{
    private KeyCode lastHitKey;
    public int[] keysPressed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            lastHitKey = KeyCode.Q;
            Debug.Log("1");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            lastHitKey = KeyCode.W;
            Debug.Log("2");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            lastHitKey = KeyCode.E;
            Debug.Log("3");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            lastHitKey = KeyCode.R;
            Debug.Log("4");
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            lastHitKey = KeyCode.T;
            Debug.Log("5");
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            lastHitKey = KeyCode.Y;
            Debug.Log("6");
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            lastHitKey = KeyCode.U;
            Debug.Log("7");
        }
        
        if (Input.GetKeyDown(KeyCode.I))
        {
            lastHitKey = KeyCode.I;
            Debug.Log("8");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            lastHitKey = KeyCode.O;
            Debug.Log("9");
        }
    }
}
