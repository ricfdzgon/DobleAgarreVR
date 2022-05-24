using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    void Start()
    {
        transform.position = RandomPosition();
    }

    void Update()
    {

    }

    public Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-10.0f, 10.0f), 0.5f, Random.Range(-10.0f, 10.0f));
    }
}
