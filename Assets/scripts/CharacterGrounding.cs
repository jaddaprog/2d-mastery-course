using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGrounding : MonoBehaviour
{

    [SerializeField] private Transform leftFoot;
    [SerializeField] private Transform rightFoot;
    [SerializeField] private float maxDistance = .25f;
    [SerializeField] private LayerMask layerMask;

   [SerializeField] public bool IsGrounded { get; internal set; }

    // Update is called once per frame
    void Update()
    {
        CheckFootForGrounding(leftFoot);
        if (IsGrounded == false)
        {
            CheckFootForGrounding(rightFoot);
        }
       // Debug.Log(IsGrounded);
    }
    

    private void CheckFootForGrounding(Transform foot)
    {
        var raycastHit = Physics2D.Raycast(foot.position, Vector2.down, maxDistance, layerMask);
        Debug.DrawRay(foot.position, Vector3.down * maxDistance, Color.red);
        if (raycastHit.collider != null)
        {
            IsGrounded = true;
        }
        else
        {
            IsGrounded = false;
        }
    }
}
