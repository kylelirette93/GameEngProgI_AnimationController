using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggerParameterController : MonoBehaviour
{
    Animator animator;
    bool isOpen = false;
    public TextMeshProUGUI chestText;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isOpen)
        {
            isOpen = true;
            animator.SetTrigger("open");
            chestText.text = "Chest is open";
            Debug.Log("Trigger 'Open' is set");
        }
        else if (Input.GetKeyDown(KeyCode.Space) && isOpen)
        {
            animator.SetTrigger("close");
            chestText.text = "Chest is closed";
            Debug.Log("Trigger 'Close' is set");
            isOpen = false;
        }
    }
}
