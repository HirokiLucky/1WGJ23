using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    [SerializeField] private GameObject rock;
    
    void Start()
    {
        StartCoroutine("Spawn");
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            Instantiate(rock, transform.position, transform.rotation);
        }
    }
    
    
}
