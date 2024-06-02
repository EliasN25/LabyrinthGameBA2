using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{

    [SerializeField] GameState state;
    [SerializeField] PauseScreen pauseScreen;


        // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        ChangeState(GameState.PAUSE);
    }

    public void PauseLevel() {
        Time.timeScale = 0;
        ChangeState(GameState.PAUSE);
    }

    public void ContinueLevel() {
        Time.timeScale = 1;
        ChangeState(GameState.LEVEL);
    }

    public void StartGame() {
        Time.timeScale = 1;
        ChangeState(GameState.LEVEL);
    }
 
    public void LoadNextLevel() {

    }

    public GameState GetState() {
        return this.state;
    }

    public void ChangeState(GameState state1) {
        state = state1;
    }

    public bool IsState(GameState state1) {
        return this.state == state1;
    }

    public void MuteSound() {
        AudioListener.volume = 0;
    }

    public void UnmuteSound() {
        AudioListener.volume = 1;
    }

    public void Exit() {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }


}
