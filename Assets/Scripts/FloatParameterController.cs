using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FloatParameterController : MonoBehaviour
{
    Animator animator;

    public float minLightSpeed = 0.0f;
    public float maxLightSpeed = 5.0f;

    public float currentLightSpeed;
    public TextMeshProUGUI lightText;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float mouseScrollInput = Input.mouseScrollDelta.y;
        lightText.text = "Light Speed: " + currentLightSpeed.ToString();

        currentLightSpeed += mouseScrollInput;

        currentLightSpeed = Mathf.Clamp(currentLightSpeed, minLightSpeed, maxLightSpeed);

        animator.SetFloat("lightSpeed", currentLightSpeed);
    }
}
