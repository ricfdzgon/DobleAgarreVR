using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public GameObject bolaPrefab;

    public InputAction TargetGenerationAction;
    void Start()
    {
        TargetGenerationAction.performed += TargetGenerationActionPerformed;
        TargetGenerationAction.Enable();
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

    void TargetGenerationActionPerformed(InputAction.CallbackContext ctxt)
    {
        GenerateTargets();
    }
}
