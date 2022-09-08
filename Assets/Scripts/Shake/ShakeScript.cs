using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeScript : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        Vector3 obPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 obWorldPoint = Camera.main.ScreenToWorldPoint(obPoint);
        transform.position = obWorldPoint;
    }
}
