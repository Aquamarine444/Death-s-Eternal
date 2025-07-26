using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject DialogueMessage;
    public TMP_Text Message;

    public bool Underworld;
    public bool Aboveworld;
    public bool Docks;

    private PhaseManager Phases;
    public GameObject Manager;

    private void Start()
    {
        Phases = Manager.GetComponent<PhaseManager>();
    }

    private void Update()
    {
        if (Phases.Phase1)
        {
            if (Underworld)
            {
                if (Input.GetKeyDown(KeyCode.X))
                {
                    DialogueMessage.SetActive(true);
                    Message.text = "Why would I go down there?";
                }
            }

            if (Aboveworld)
            {
                if (Input.GetKeyDown(KeyCode.X))
                {
                    DialogueMessage.SetActive(true);
                    Message.text = "Let's get this over with...";
                }
            }

            if (Docks)
            {
                if (Input.GetKeyDown(KeyCode.X))
                {
                    DialogueMessage.SetActive(true);
                    Message.text = "I don't have any souls that need ferrying...";
                }
            }
        }
    }

    private void FixedUpdate()
    {
        if (DialogueMessage.activeSelf == true)
        {
            if (Input.anyKeyDown)
            {
                DialogueMessage.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("AboveWorld"))
        {
            Aboveworld = true;
        }

        if (collision.CompareTag("Underworld"))
        {
            Underworld = true;
        }

        if (collision.CompareTag("Docks"))
        {
            Docks = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("AboveWorld"))
        {
            Aboveworld = false;
        }

        if (collision.CompareTag("Underworld"))
        {
            Underworld = false;
        }

        if (collision.CompareTag("Docks"))
        {
            Docks = false;
        }
    }
}
