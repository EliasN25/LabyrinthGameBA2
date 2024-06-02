using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{

    [SerializeField]
    GameHandler gameHandler;
    [SerializeField]
    protected TilemapVisualizer tilemapVisualizer = null;

    public void PauseLevel() {
        gameHandler.PauseLevel();
        gameObject.SetActive(true);
    }

    public void ContinueButton() {
        gameHandler.ContinueLevel();
        gameObject.SetActive(false);
    }

    public void ExitButton() {
        gameObject.SetActive(false);
        gameHandler.ChangeState(GameState.LEVEL);
        tilemapVisualizer.Clear();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
