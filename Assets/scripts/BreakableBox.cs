
using UnityEngine;

public class BreakableBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.WasHitByPlayer()
            && collision.WasHitFromBottomSide())
        {
            Destroy(gameObject);
        }
    }


    
}

