using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WaitingLine : MonoBehaviour
{
    public float waitingLineX;

    
    void Start()
    {
        Vector3 pos = transform.position;
        waitingLineX = pos.x;
    }

    
}
