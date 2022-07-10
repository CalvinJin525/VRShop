using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformAnimator : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetFloat("BlendAnimation", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
