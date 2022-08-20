using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UICoinsText : MonoBehaviour
{

    TextMeshProUGUI tmproText;

    // Start is called before the first frame update
    void Start()
    {
        tmproText = GetComponent<TextMeshProUGUI>();
        tmproText.text = 0.ToString();
        GameManager.Instance.OnCoinsChanged += HandleCoinsChanged;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void HandleCoinsChanged(int coins)
    {
        tmproText.text = coins.ToString();
    }
}
