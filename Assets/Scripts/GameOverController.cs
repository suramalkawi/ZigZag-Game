using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{

    // Reference to the death zone (attach an empty GameObject with a collider below the path)
    private float fallThreshold = -5f;


    // Game Over flag
   private bool gameOver=false;

    void Update()
    {
        // Check if the player has fallen below the death zone
        if (transform.position.y < fallThreshold && !gameOver)
        {
            // Player has fallen off the path, trigger Game Over
            GameOver();
        }
    }

    void GameOver()
    {
        // Set the Game Over flag
        gameOver = true;

        Invoke("ReloadScene", 1f);
        
            // You can implement other game over actions here (e.g., show a game over screen, reset the level, etc.)

            // For example, reloading the scene after a delay
            // Invoke("ReloadScene", 2f);
    }

    void ReloadScene()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
