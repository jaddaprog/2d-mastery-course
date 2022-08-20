using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    private Checkpoint[] checkpoints;

    void Start()
    {
        checkpoints = GetComponentsInChildren<Checkpoint>();  
    }

    public Checkpoint GetLastCheckpointThatWasPassed()
    {
        return checkpoints.LastOrDefault(t => t.Passed);
    }

}
