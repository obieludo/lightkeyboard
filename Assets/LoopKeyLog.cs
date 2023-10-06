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
    }
}
