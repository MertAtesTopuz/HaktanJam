using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class dialougeTrigger : MonoBehaviour
{
    public NPCConversation myConversation;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("sda");
        ConversationManager.Instance.StartConversation(myConversation);
        Destroy(gameObject);
    }

}
