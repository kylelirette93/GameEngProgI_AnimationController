using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float mouseScrollInput = Input.mouseScrollDelta.y;
        animator.SetFloat("lightSpeed", mouseScrollInput);
    }
}
