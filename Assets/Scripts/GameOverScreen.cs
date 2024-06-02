using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    [SerializeField]
    GameHandler gameHandler;
    [SerializeField]
    protected TilemapVisualizer tilemapVisualizer = null;

    public void Setup() {
        gameObject.SetActive(true);
    }

    public void RestartButton() {
        gameObject.SetActive(false);
        gameHandler.ChangeState(GameState.LEVEL);
        tilemapVisualizer.Clear();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitButton() {
         gameHandler.Exit();
    }
}
