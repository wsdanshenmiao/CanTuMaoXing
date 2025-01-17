using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Exit : MonoBehaviour
{
    private PlayerInputController controller;
    private void Awake()
    {
        controller = new PlayerInputController();
        controller.GamePlay.Cancel.started += ExitScene;
    }

    private void OnEnable()
    {
        controller.Enable();
    }

    private void OnDisable()
    {
        controller.Disable();
    }

    private void ExitScene(InputAction.CallbackContext context)
    {
        Debug.Log("离开");
        SceneManager.Instance.ExitScene();
    }
}
