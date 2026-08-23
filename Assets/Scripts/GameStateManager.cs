using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.SceneManagement;
public class GameStateManager : MonoBehaviour
{
    private bool gameEnded = false;
    
    private void Update()
    {

        if(gameEnded)
        {
            SceneManager.LoadScene("MainMenu");

        }
        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        gameEnded = true;
    }
}
