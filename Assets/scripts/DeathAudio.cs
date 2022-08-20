using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAudio : MonoBehaviour
{

    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.OnLivesChanged += PlayDeathSound;
    }

    private void OnDestroy()
    {
        GameManager.Instance.OnLivesChanged -= PlayDeathSound;
    }

    private void PlayDeathSound(int lives)
    {
        audioSource.Play();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
