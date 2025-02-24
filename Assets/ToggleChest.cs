using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToggleChest : MonoBehaviour
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
            animator.SetTrigger("open");
            chestText.text = "Chest is open";
        }
    }
}
