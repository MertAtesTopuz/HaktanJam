using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    public GameObject flower0, flower1, flower2, flower3, flower4;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("UIitem"))
        {
            if(InventoryManager.instance.flower0Check == true)
            {
                flower0.SetActive(true);
                InventoryManager.instance.flower0Del = true;
            }
            if(InventoryManager.instance.flower1Check == true)
            {
                flower1.SetActive(true);
                InventoryManager.instance.flower1Del = true;
            }

            if(InventoryManager.instance.flower2Check == true)
            {
                flower2.SetActive(true);
                InventoryManager.instance.flower2Check = true;
            }
            if(InventoryManager.instance.flower3Check == true)
            {
                flower3.SetActive(true);
                InventoryManager.instance.flower3Del = true;
            }

            if(InventoryManager.instance.flower4Check == true)
            {
                flower4.SetActive(true);
                InventoryManager.instance.flower4Del = true;
            }
        }
    }
}
