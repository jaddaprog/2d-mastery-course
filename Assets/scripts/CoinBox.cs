using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBox : MonoBehaviour
{

    [SerializeField] private SpriteRenderer enabledSprite;

    [SerializeField] private SpriteRenderer disabledSprite;

    [SerializeField] private int totalCoins = 1;
    
    private Animator animator;
    private int remainingCoins;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        remainingCoins = totalCoins;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (remainingCoins > 0
            && collision.WasHitByPlayer()
            && collision.WasHitFromBottomSide()) 
        {
            GameManager.Instance.AddCoin();
            remainingCoins--;
            animator.SetTrigger("FlipCoin");
            if (remainingCoins <= 0)
            {
                enabledSprite.enabled = false;
                disabledSprite.enabled = true;
            }
        }
    }
}
