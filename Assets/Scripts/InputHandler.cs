using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputHandler : MonoBehaviour
{

    [SerializeField] PauseScreen pauseScreen;
    [SerializeField] GameHandler gameHandler;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameHandler.GetState() == GameState.LEVEL) {
            if (Input.GetKeyUp(KeyCode.Escape)) {
                pauseScreen.PauseLevel();
            }
        } else if (gameHandler.GetState() == GameState.PAUSE) {
            if (Input.GetKeyUp(KeyCode.Escape)) {
                pauseScreen.ContinueButton();
            }
        }
        
    }
}
