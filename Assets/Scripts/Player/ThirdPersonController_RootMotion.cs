using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController_RootMotion : MonoSingleton<ThirdPersonController_RootMotion>
{
    [SerializeField] private float moveSpeed = 5.0f;

    [SerializeField] private Animator animator;

    private readonly int input_x = Animator.StringToHash("input_x");
    private readonly int input_y = Animator.StringToHash("input_y");
    private readonly int is_running = Animator.StringToHash("is_running");

    private void Update()
    {
        var inputX = Input.GetAxis("Horizontal");
        var inputY = Input.GetAxis("Vertical");
        var isRunning = Input.GetKey(KeyCode.LeftShift);

        animator.SetFloat(input_x, inputX);
        animator.SetFloat(input_y, inputY);
        animator.SetBool(is_running, isRunning);
    }
}
