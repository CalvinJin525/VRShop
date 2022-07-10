using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshAnimationSwitcher : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool runningState = Input.GetKey(KeyCode.R);
        bool jumpingState = Input.GetKey(KeyCode.J);
        bool idle = !(runningState || jumpingState);

        animator.SetBool("IsIdle", idle);
        animator.SetBool("IsRunning", runningState);
        animator.SetBool("IsJumping", jumpingState);
    }
}
