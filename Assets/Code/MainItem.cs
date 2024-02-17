using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainItem : MonoBehaviour
{
    [HideInInspector] public Transform mainPos;
    public Item item;

    void Start()
    {
        mainPos = GetComponent<Transform>();
    }

    void Update()
    {
        mainPos.position = transform.position;
    }
}
