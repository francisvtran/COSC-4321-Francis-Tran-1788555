using System;
using System.Collections;
using System.Collections.Generic;
using GorillaZilla;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class StartGameButton : MonoBehaviour
{
    void Start()
    {
        // Start the coroutine to delay the game start
        StartCoroutine(StartGameAfterDelay());
    }

    private IEnumerator StartGameAfterDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(5);

        // Now that the delay is over, start the game
        OnButtonClick();
    }
    private void OnButtonClick()
    {
        GameObject.FindObjectOfType<GameManager>().StartGame();
    }
}