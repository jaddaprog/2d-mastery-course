using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAudio : MonoBehaviour
{
     AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.OnCoinsChanged += PlayAudio;
    }

    private void OnDestroy()
    {
        GameManager.Instance.OnCoinsChanged -= PlayAudio;
    }
    private void PlayAudio(int coins)
    {
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
