using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Hints : MonoBehaviour
{
    [SerializeField] private NPCConversation conversation;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {

                ConversationManager.Instance.StartConversation(conversation);
            }
        }
    }
}
