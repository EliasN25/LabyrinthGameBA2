using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    [SerializeField]
    GameHandler gameHandler;
    [SerializeField]
    GameObject healthBar;

    public void StartGame() {
        gameHandler.StartGame();
        gameObject.SetActive(false);
    }

    public void ExitButton() {
        Application.Quit();
    }

}
