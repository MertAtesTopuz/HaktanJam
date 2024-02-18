using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap3Maker : MonoBehaviour
{
    public GameObject leaf;
    public GameObject hole;
    public GameObject stake;

    public GameObject trapCol;

    void Update()
    {
        if (leaf.activeSelf == true && hole.activeSelf == true && stake.activeSelf == true)
        {
            trapCol.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("UIitem"))
        {
            if(InventoryManager.instance.leafChekcT3 == true)
            {
                leaf.SetActive(true);
                InventoryManager.instance.leafT3Del = true;
            }
            if(InventoryManager.instance.holeCheckT3 == true)
            {
                hole.SetActive(true);
                InventoryManager.instance.holeT3Del = true;
            }

            if(InventoryManager.instance.stakeCheckT3 == true)
            {
                stake.SetActive(true);
                InventoryManager.instance.stakeT3Del = true;
            }
        }
    }
}
