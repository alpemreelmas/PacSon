using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interfaces;

public class BaseMapScript : MonoBehaviour, ISpawnPoint
{

    public GameObject student;
    public Vector2[] spawnPoints
    {
        get
        {
            return new Vector2[] { new Vector2(0, 0), new Vector2(1, 1), new Vector2(2, 2) };
        }
    }

    void Awake()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Instantiate(student, new Vector2(spawnPoints[i].x, spawnPoints[i].y), Quaternion.identity);
        }

    }

}

