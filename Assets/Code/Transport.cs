using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour
{
     public Transform targetPosition; 
    
    



    public void OnTriggerEnter2D(Collider2D collision)
    {
        print("sdas");
        collision.gameObject.transform.position = targetPosition.position;
        PNCControl ref_ = collision.gameObject.GetComponent<PNCControl>();
        ref_.followSpot = targetPosition.position;
        Vector3 lastpos = Camera.main.transform.position;
        Camera.main.transform.position = targetPosition.position;
        Camera.main.transform.position = new Vector3(targetPosition.position.x, targetPosition.position.y + 4, lastpos.z);
    }
}
