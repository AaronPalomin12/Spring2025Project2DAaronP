using UnityEngine;
using UnityEngine.SceneManagement;  // Import Scene Management

public class player_dead : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bomb_enemy"))
        {
            // Destroy the player
            Destroy(this.gameObject);

            // Restart the scene after a delay
            Invoke("RestartGame", 1f);
        }

        if (collision.gameObject.CompareTag("power_up"))
        {
            // Destroy the player
            Destroy(collision.gameObject);
            score_manager.instance.addPoints();
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
