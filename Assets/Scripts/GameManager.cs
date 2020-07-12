using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  bool gameEnded = false;

  public float deathScreenDelay = 1f;
  public GameObject completeLevelUI;
  public PlayerMovement player;
  public void EndGame()
  {
    if (!gameEnded)
    {
      gameEnded = true;
      Invoke("Restart", deathScreenDelay);
    }
  }

  public void Update()
  {
    if (Input.GetKey("r"))
    {
      Restart();
    }
  }

  void Restart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void CompleteLevel()
  {
    completeLevelUI.SetActive(true);
    // player.sidewaysForce = 0f;
    player.jumpForce = 0f;
    player.forwardForce = 0f;
    player.rb.AddForce(0, 0, -100);
  }
}
