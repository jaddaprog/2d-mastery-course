using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillOnTouch : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMovementController playerMovementCollider = collision.collider.GetComponent<PlayerMovementController>();
        if(playerMovementCollider != null)
        {
            GameManager.Instance.KillPlayer();
        }
    
    }

  
}
