using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour
{
    private float rotateSpeed;
    
    void Awake()
    {
        rotateSpeed = 3f * Random.value;
    }
    
    void Update()
    {
        transform.Rotate(new Vector3(0,0,rotateSpeed));

        if (transform.position.y < -7)
        {
            Destroy(gameObject);
        }
    }
}
