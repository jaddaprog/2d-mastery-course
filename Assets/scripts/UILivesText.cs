using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UILivesText : MonoBehaviour
{
    TextMeshProUGUI tmproText;

    private void Awake()
    {
        tmproText = GetComponent<TextMeshProUGUI>();
    }
    // Start is called before the first frame update
    void Start() { 
    
        GameManager.Instance.OnLivesChanged += HandleOnLivesChanged;
        tmproText.text = GameManager.Instance.Lives.ToString();
    }

    private void HandleOnLivesChanged(int livesRemaining)
    {
        tmproText.text = livesRemaining.ToString();
    }
    
}
