using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using Unity.Mathematics;
using System;

public class NPC : MonoBehaviour
{
    public NPCConversation[] myConversation;
    public int myConversationCount;
    public float Distace;
    public float range = 5;
    public Transform target;

    public GameObject UI;

    private void Update()
    {
        Distace = gameObject.transform.position.x -target.position.x;
        Distace = Mathf.Abs(Distace);
        if (Distace < range)
        {
            UI.SetActive(true);
        }
        else
        {
            UI.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            ConversationManager.Instance.SetInt("New1", 2);
            print(ConversationManager.Instance.GetInt("New1"));
        }

    }

    public void OnMouseOver()
    {
        if (Distace > range)
            return;
        if(Input.GetMouseButtonDown(0))
            ConversationManager.Instance.StartConversation(myConversation[myConversationCount]);
    }



}
