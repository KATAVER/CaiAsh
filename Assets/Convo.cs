using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Convo : MonoBehaviour
{

    [SerializeField] private NPCConversation conversation;

    // Start is called before the first frame update
    void Start()
    {
        ConversationManager.Instance.StartConversation(conversation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
