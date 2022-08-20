using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public static GameManager Instance { get; private set; }


    public int Lives { get; private set; }

    private int coins;

    public event Action<int> OnLivesChanged;
    public event Action<int> OnCoinsChanged;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            RestartGame();
        }
    }

    internal void KillPlayer()
    {
        Lives--;
        Debug.Log(Lives);
        Debug.Log(OnLivesChanged);
        if (OnLivesChanged != null)
        {
            OnLivesChanged(Lives);
        }

        if (Lives <= 0)
        {
            RestartGame();
        } else
        {
            SendPlayerToCheckpoint();
        }
    }

    private void SendPlayerToCheckpoint()
    {
        var checkpointManager = FindObjectOfType<CheckPointManager>();

        var checkpoint = checkpointManager.GetLastCheckpointThatWasPassed();

        var player = FindObjectOfType<PlayerMovementController>();
        player.transform.position = checkpoint.transform.position;
    }


    internal void AddCoin()
    {
        coins++;
        if(OnCoinsChanged != null)
        {
            OnCoinsChanged(coins);
        }
    }

    private void RestartGame()
    {
        Lives = 3;
        coins = 0;
        if(OnCoinsChanged != null)
        {
            OnCoinsChanged(coins);
        }
        SceneManager.LoadScene(0);
    }
}
