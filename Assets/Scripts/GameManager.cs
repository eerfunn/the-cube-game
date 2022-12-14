using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 5f;
    public GameObject LevelCompletedUI;
    public void LevelCompleted()
    {
        LevelCompletedUI.SetActive(true);
    }
    public void EndGame()
    {
        if(gameHasEnded == false) { 
            gameHasEnded = true; 
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
