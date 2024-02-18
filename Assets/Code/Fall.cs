using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public GameObject trapUPpos;
    private void OnTriggerEnter2D(Collider2D other)
    {
        print(other.name);
        if (other.tag == "kurt")
        {
            kurtMov kurt = other.gameObject.GetComponent<kurtMov>();
            kurt.fall = false;
            kurt.gameObject.transform.position = trapUPpos.transform.position;  
            BoxCollider2D cl = kurt.gameObject.GetComponent<BoxCollider2D>();
            cl.enabled = false;
            kurt.trap3Maker.gameObject.GetComponent<Collider2D>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;

        }
    }
}
