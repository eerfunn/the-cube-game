using UnityEngine;

public class LevelCompleted : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.LevelCompleted();
    }
}
