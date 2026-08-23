using UnityEngine;
using System.Collections;
public class GameStateManager : MonoBehaviour
{
    private bool gameEnded = false;
    
    private void Update()
    {
        if(gameEnded) return;
        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameEnded = true;
    }
}
