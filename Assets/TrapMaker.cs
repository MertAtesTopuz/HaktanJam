using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMaker : MonoBehaviour
{
    public GameObject piece1;
    public GameObject piece2;
    public GameObject piece3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("UIitem"))
        {
            if(InventoryManager.instance.piece1Control == true)
            {
                piece1.SetActive(true);
                InventoryManager.instance.piece1Del = true;
            }
            if(InventoryManager.instance.piece2Control == true)
            {
                piece2.SetActive(true);
                InventoryManager.instance.piece2Del = true;
            }
            if(InventoryManager.instance.piece3Control == true)
            {
                piece3.SetActive(true);
                InventoryManager.instance.piece3Del = true;
            }
        }
    }
}
