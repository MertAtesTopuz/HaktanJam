using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap2Maker : MonoBehaviour
{
    public GameObject leaf;
    public GameObject rope;
    public GameObject stone;

    public GameObject trapCol;

    void Update()
    {
        if (leaf.activeSelf == true && rope.activeSelf == true && stone.activeSelf == true)
        {
            trapCol.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("UIitem"))
        {
            if(InventoryManager.instance.leafChekcT2 == true)
            {
                leaf.SetActive(true);
                InventoryManager.instance.leafT2Del = true;
            }
            if(InventoryManager.instance.stoneCheckT2 == true)
            {
                stone.SetActive(true);
                InventoryManager.instance.stoneT2Del = true;
            }

            if(InventoryManager.instance.ropeCheckT2 == true)
            {
                rope.SetActive(true);
                InventoryManager.instance.ropeT2Del = true;
            }
        }
    }
}
