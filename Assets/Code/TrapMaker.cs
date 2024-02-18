using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMaker : MonoBehaviour
{
    public GameObject leaf;
    public GameObject trap;

    public GameObject trapCol;

    void Update()
    {
        if (leaf.activeSelf == true && trap.activeSelf == true)
        {
            trapCol.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("UIitem"))
        {
            if(InventoryManager.instance.leafChekcT1 == true)
            {
                leaf.SetActive(true);
                InventoryManager.instance.leafT1Del = true;
            }
            if(InventoryManager.instance.trapCheckT1 == true)
            {
                trap.SetActive(true);
                InventoryManager.instance.trapT1Del = true;
            }
        }
    }
}
