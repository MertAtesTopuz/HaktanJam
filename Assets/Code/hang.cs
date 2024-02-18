using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hang : MonoBehaviour
{
    public GameObject trap;
    public GameObject trapUP;
    public GameObject trapUPpos;
    private void OnTriggerEnter2D(Collider2D other)
    {
        print(other.name);
        if (other.tag == "kurt")
        {
            trap.SetActive(false);
            trapUP.SetActive(true);
            kurtMov trp2 =  other.gameObject.GetComponent<kurtMov>();
            trp2.hang = false;
            trp2.gameObject.transform.position = trapUPpos.transform.position;
            BoxCollider2D cl = trp2.gameObject.GetComponent<BoxCollider2D>();
            cl.enabled = false;

        }
    }
}
