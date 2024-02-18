using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beartrap : MonoBehaviour
{
    public GameObject trapclose;
    public GameObject trapopen;
    private void OnTriggerEnter2D(Collider2D other)
    {
        print(other.name);
        if(other.tag == "kurt")
            
        {
            trapclose.SetActive(true);
            trapopen.SetActive(false);
            other.gameObject.transform.position = trapopen.transform.position;

        }
    }
}
