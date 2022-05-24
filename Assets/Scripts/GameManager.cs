using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject bolaPrefab;
    void Start()
    {
        GenerateTargets();
    }

    void Update()
    {

    }

    private void GenerateTargets()
    {
        for (int i = 0; i < 12; i++)
        {
            Instantiate(bolaPrefab);
        }
    }
}
