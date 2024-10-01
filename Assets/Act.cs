using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Act : MonoBehaviour
{

    [SerializeField] private NPCConversation conversation;
    [SerializeField] private NPCConversation conversation2;
    public int count = 0;
    public GameObject activae1;
    public GameObject activae2;
    public GameObject deactivate1;
    public GameObject deactivate2;

    // Update is called once per frame
    void Update()
    {

    }

    public void activate()
    {
        activae1.SetActive(true);
        activae2.SetActive(true);
    }
    public void deactivate()
    {
        deactivate1.SetActive(false);
        deactivate2.SetActive(false);
    }

    public void add()
    {
        count++;
        if (count > 4)
        {
            activae1.SetActive(true) ;
            deactivate1.SetActive(false);
        }

    }
}
