using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField] private Text cdText;
    [SerializeField] private int num;
    
    void Start()
    {
        StartCoroutine("Count");
    }

    IEnumerator Count()
    {
        for (int i = num; i >= 0; i--)
        {
            cdText.text = i.ToString();
            yield return new WaitForSeconds(1);
        }
    }
}
