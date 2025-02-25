using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoolParameterController : MonoBehaviour
{
    Animator animator;
    public bool isRotating = false;
    public TextMeshProUGUI boolText;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetBool("isRotating", isRotating);

        if (Input.GetKeyDown(KeyCode.Tab) && !isRotating)
        {
            isRotating = true;
            boolText.text = "bool is " + isRotating.ToString();
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && isRotating)
        {
            isRotating = false;
            boolText.text = "bool is " + isRotating.ToString();
        }
    }
}
