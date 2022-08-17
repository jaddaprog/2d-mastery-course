using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator animator;
    private IMove mover;
    private SpriteRenderer spriteRenderer;
    void Awake()
    {
        animator = GetComponent<Animator>();
        mover = GetComponent<IMove>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = mover.Speed;
        animator.SetFloat("Speed", Mathf.Abs(speed));

        if(speed != 0)
        {
            spriteRenderer.flipX = speed > 0;
        }
    }
}
