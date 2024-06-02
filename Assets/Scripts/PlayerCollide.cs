using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollide : MonoBehaviour
{



    [SerializeField]
    GameHandler gameHandler;
    [SerializeField]
    protected TilemapVisualizer tilemapVisualizer = null;



    private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Flag") {
                tilemapVisualizer.Clear();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

}
